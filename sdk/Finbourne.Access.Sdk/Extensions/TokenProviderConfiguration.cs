﻿/*
 * FINBOURNE Access Management API
 *
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Linq;
using Finbourne.Access.Sdk.Client;

namespace Finbourne.Access.Sdk.Extensions
{
    /// <summary>
    /// Custom class, derived from the auto-generated Configuration, which allows the access token to be pulled from an ITokenProvider when required
    ///</summary>
    public class TokenProviderConfiguration : Client.Configuration
    {
        private readonly ITokenProvider _tokenProvider;

        /// <summary>
        /// Create a new Configuration using the supplied token provider
        ///</summary>
        public TokenProviderConfiguration(ITokenProvider tokenProvider)
        {
            _tokenProvider = tokenProvider;
        }

        /// <summary>
        /// Gets/sets the accesstoken
        ///</summary>
        public override string AccessToken
        {
            get => _tokenProvider.GetAuthenticationTokenAsync().Result;
            set => throw new InvalidOperationException("AccessToken is not assignable");
        }

        /// <summary>
        /// Merge configuration with the global config.
        /// </summary>
        public void MergeWithGlobalConfiguration()
        {
            var global = GlobalConfiguration.Instance;

            Dictionary<string, string> apiKey = global.ApiKey.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            Dictionary<string, string> apiKeyPrefix = global.ApiKeyPrefix.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            Dictionary<string, string> defaultHeaders = global.DefaultHeaders.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var kvp in ApiKey) apiKey[kvp.Key] = kvp.Value;
            foreach (var kvp in ApiKeyPrefix) apiKeyPrefix[kvp.Key] = kvp.Value;
            foreach (var kvp in DefaultHeaders) defaultHeaders[kvp.Key] = kvp.Value;

            ApiKey = apiKey;
            ApiKeyPrefix = apiKeyPrefix;
            DefaultHeaders = defaultHeaders;
            BasePath = BasePath ?? global.BasePath;
            Timeout = Timeout;
            Proxy = Proxy ?? global.Proxy;
            UserAgent = UserAgent ?? global.UserAgent;
            Username = Username ?? global.Username;
            Password = Password ?? global.Password;
            OAuthTokenUrl = OAuthTokenUrl ?? global.OAuthTokenUrl;
            OAuthClientId = OAuthClientId ?? global.OAuthClientId;
            OAuthClientSecret = OAuthClientSecret ?? global.OAuthClientSecret;
            OAuthFlow = OAuthFlow ?? global.OAuthFlow;
            TempFolderPath = TempFolderPath ?? global.TempFolderPath;
            DateTimeFormat = DateTimeFormat ?? global.DateTimeFormat;
            ClientCertificates = ClientCertificates ?? global.ClientCertificates;
        }
    }
}
