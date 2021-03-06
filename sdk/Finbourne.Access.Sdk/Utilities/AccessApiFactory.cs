using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Finbourne.Access.Sdk.Client;
using ApiClient = Finbourne.Access.Sdk.Client.ApiClient;

namespace Finbourne.Access.Sdk.Utilities
{
    /// <summary>
    /// Factory to provide instances of the autogenerated LusidApi
    /// </summary>
    public interface IAccessApiFactory
    {
        /// <summary>
        /// Return the specific autogenerated Api
        /// </summary>
        TApi Api<TApi>() where TApi : class, IApiAccessor;
    }

    /// <inheritdoc />
    public class AccessApiFactory : IAccessApiFactory
    {
        private static readonly IEnumerable<Type> ApiTypes = Assembly.GetAssembly(typeof(ApiClient))
            .GetTypes()
            .Where(t => typeof(IApiAccessor).IsAssignableFrom(t) && t.IsClass);

        private readonly IReadOnlyDictionary<Type, IApiAccessor> _apis;

        /// <summary>
        /// Create a new factory using the specified configuration
        /// </summary>
        public AccessApiFactory(ApiConfiguration apiConfiguration)
        {
            if (apiConfiguration == null) throw new ArgumentNullException(nameof(apiConfiguration));

            // Validate Uris
            if (!Uri.TryCreate(apiConfiguration.TokenUrl, UriKind.Absolute, out var _))
            {
                throw new UriFormatException($"Invalid Token Uri: {apiConfiguration.TokenUrl}");
            }

            if (!Uri.TryCreate(apiConfiguration.ApiUrl, UriKind.Absolute, out var _))
            {
                throw new UriFormatException($"Invalid LUSID Uri: {apiConfiguration.ApiUrl}");
            }

            // Create configuration
            var tokenProvider = new ClientCredentialsFlowTokenProvider(apiConfiguration);
            var configuration = new TokenProviderConfiguration(tokenProvider)
            {
                BasePath = apiConfiguration.ApiUrl,
            };
            
            configuration.AddDefaultHeader("X-LUSID-Application", apiConfiguration.ApplicationName);

            _apis = Init(configuration);
        }

        /// <summary>
        /// Create a new factory using the specified configuration
        /// </summary>
        public AccessApiFactory(Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException(nameof(configuration));

            _apis = Init(configuration);
        }

        private static Dictionary<Type, IApiAccessor> Init(Configuration configuration)
        {
            // DEV-7152: we must explicitly Dispose an HttpClient in .NET Core 2.2 in order to avoid
            // socket leaks on Linux / MacOS: https://github.com/dotnet/runtime/issues/29327
            //
            // RestSharp.Portable.RestClientBase implements a finalizer, which, when run, does 
            // NOT dispose its HttpClient instance, but DOES set a flag which means thereafter 
            // the HttpClient can NEVER be disposed.
            //
            // We are using a finalizer on ApiClient to ensure the HttpClient always gets disposed
            // (see Utilities/ApiClient.Dispose.cs), but finalizers are not executed in a deterministic
            // order, so there is a race condition: if ~RestClient() runs before ~ApiClient(), then
            // RestClient ends up in a 'disposed=true' state and the HttpClient can then NEVER then be
            // explicitly disposed.
            //
            // Calling SuppressFinalize ensures ~RestClient() never runs, so ApiClient.DisposeImpl can
            // then call RestClient.Dispose, which does the correct cleanup.
            GC.SuppressFinalize(configuration.ApiClient.RestClient);


            var dict = new Dictionary<Type, IApiAccessor>();
            foreach (Type api in ApiTypes)
            {
                if (!(Activator.CreateInstance(api, configuration) is IApiAccessor impl))
                {
                    throw new Exception($"Unable to create type {api}");
                }

                var @interface = api.GetInterfaces()
                    .First(i => typeof(IApiAccessor).IsAssignableFrom(i));

                dict[api] = impl;
                dict[@interface] = impl;
            }

            return dict;
        }

        /// <inheritdoc />
        public TApi Api<TApi>() where TApi : class, IApiAccessor
        {
            _apis.TryGetValue(typeof(TApi), out var api);

            if (api == null)
            {
                throw new InvalidOperationException($"Unable to find api: {typeof(TApi)}");
            }

            return api as TApi;
        }
    }
}