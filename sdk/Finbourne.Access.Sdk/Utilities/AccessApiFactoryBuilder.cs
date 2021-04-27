namespace Finbourne.Access.Sdk.Utilities
{
    /// <summary>
    /// Builder class to build instances of IAccessApiFactory
    /// </summary>
    public static class AccessApiFactoryBuilder
    {
        /// <summary>
        /// Create an IAccessApiFactory using the specified configuration file.  For details on the format of the configuration file see https://support.lusid.com/getting-started-with-apis-sdks
        /// </summary>
        public static IAccessApiFactory Build(string apiSecretsFilename)
        {
            var apiConfig = ApiConfigurationBuilder.Build(apiSecretsFilename);
            return new AccessApiFactory(apiConfig);
        }

        /// <summary>
        /// Create an IAccessApiFactory using the specified Url and Token Provider
        /// </summary>
        public static IAccessApiFactory Build(string url, ITokenProvider tokenProvider)
        {
            // TokenProviderConfiguration.ApiClient is the client used by AccessApiFactory and is 
            // NOT thread-safe, so there needs to be a separate instance for each instance of AccessApiFactory.
            // Do NOT cache the AccessApiFactory instances (DEV-6922)
            var config = new TokenProviderConfiguration(tokenProvider)
            {
                BasePath = url
            };

            return new AccessApiFactory(config);
        }
    }
}