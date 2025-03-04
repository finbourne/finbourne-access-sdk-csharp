![LUSID_by_Finbourne](./resources/Finbourne_Logo_Teal.svg)

# C# SDK for the FINBOURNE Access Management API

## Contents

- [Summary](#summary)
- [Versions](#versions)
- [Requirements](#requirements)
- [Installation](#installation)
- [Getting Started](#getting-started)
    * [Environment variables](#environment-variables)
    * [Secrets file](#secrets-file)
    * [Example](#example)
- [Endpoints and models](#endpoints-and-models)

## Summary

This is the C# SDK for the FINBOURNE Access Management API, part of the [LUSID by FINBOURNE](https://www.finbourne.com/lusid-technology) platform. To use it you'll need a LUSID account - [sign up for free at lusid.com](https://www.lusid.com/app/signup).

Access provides access control for LUSID (in conjunction with Identity) - see https://support.lusid.com/knowledgebase/article/KA-01647/ to learn more.

For more details on other applications in the LUSID platform, see [Understanding all the applications in the LUSID platform](https://support.lusid.com/knowledgebase/article/KA-01787).

This sdk supports `Production`, `Early Access`, `Beta` and `Experimental` API endpoints. For more details on API endpoint categories, see [What is the LUSID feature release lifecycle](https://support.lusid.com/knowledgebase/article/KA-01786). To find out which category an API endpoint falls into, see the [swagger page](https://fbn-prd.lusid.com/access/swagger/index.html).

This code is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project.

## Versions

- API version: 0.0.4101
- SDK version: 2.0.0

## Requirements

- net6.0;net8.0+

## Installation

The NuGet package for the FINBOURNE Access Management API SDK can installed from https://www.nuget.org/packages/Finbourne.Access.Sdk using the following

```
$ dotnet add package Finbourne.Access.Sdk
```

## Getting Started

You'll need to provide some configuration to connect to the FINBOURNE Access Management API - see the articles about [short-lived access tokens](https://support.lusid.com/knowledgebase/article/KA-01654) and a [long-lived Personal Access Token](https://support.lusid.com/knowledgebase/article/KA-01774). This configuration can be provided using a secrets file or environment variables.

For some configuration it is also possible to override the global configuration at the ApiFactory level, or at the request level. For the set of configuration which can be overridden, please see [ConfigurationOptions](sdk/Finbourne.Access.Sdk/Extensions/ConfigurationOptions.cs). For a code illustration of this configuration being overridden, please see the [example](#example).

### Environment variables

Required for a short-lived access token
``` 
FBN_TOKEN_URL
FBN_ACCESS_URL
FBN_USERNAME
FBN_PASSWORD
FBN_CLIENT_ID
FBN_CLIENT_SECRET
```

Required for a long-lived access token
``` 
FBN_ACCESS_URL
FBN_ACCESS_TOKEN
```

You can send your requests to the FINBOURNE Access Management API via a proxy, by setting `FBN_PROXY_ADDRESS`. If your proxy has basic auth enabled, you must also set `FBN_PROXY_USERNAME` and `FBN_PROXY_PASSWORD`.

Other optional configuration

```bash
# the sdk client timeout in milliseconds, the default is 1800000 (30 minutes)
# values must be between 1 and 2147483647
# please note - the chances of seeing a network issue increases with the duration of the request
# for this reason, rather than increasing the timeout, it will be more reliable to use an alternate polling style endpoint where these exist
FBN_TIMEOUT_MS
# the retries when being rate limited, the default is 2
FBN_RATE_LIMIT_RETRIES
```

### Secrets file

The secrets file must be in the current working directory. By default the SDK looks for a secrets file called `secrets.json`

Required for a short-lived access token
```json
{
    "api":
    {
        "tokenUrl":"<your-token-url>",
        "accessUrl":"https://<your-domain>.lusid.com/access",
        "username":"<your-username>",
        "password":"<your-password>",
        "clientId":"<your-client-id>",
        "clientSecret":"<your-client-secret>"
    }
}
```

Required for a long-lived access token
```json
{
    "api":
    {
        "accessUrl":"https://<your-domain>.lusid.com/access",
        "accessToken":"<your-access-token>"
    }
}
```

You can send your requests to the FINBOURNE Access Management API via a proxy, by adding a proxy section. If your proxy has basic auth enabled, you must also supply a `username` and `password` in this section.

```json
{
    "api":
    {
        "accessUrl":"https://<your-domain>.lusid.com/access",
        "accessToken":"<your-access-token>"
    },
    "proxy":
    {
        "address":"<your-proxy-address>",
        "username":"<your-proxy-username>",
        "password":"<your-proxy-password>"
    }
}
```

Other optional configuration

```javascript
{
    "api": 
    {
        // the sdk client timeout in milliseconds, the default is 1800000 (30 minutes)
        // values must be between 1 and 2147483647
        // please note - the chances of seeing a network issue increases with the duration of the request
        // for this reason, rather than increasing the timeout, it will be more reliable to use an alternate polling style endpoint where these exist
        "timeoutMs":"<timeout-in-ms>",
        // the retries when being rate limited, the default is 2
        "rateLimitRetries":<retries-when-being-rate-limited>
    }
}
```

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Extensions;
using Finbourne.Access.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""accessUrl"": ""https://<your-domain>.lusid.com/access"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ApplicationMetadataApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ApplicationMetadataApi>();

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfAccessControlledResource result = apiInstance.ListAccessControlledResources(opts: opts);

                // ListAccessControlledResources: Get resources available for access control
                ResourceListOfAccessControlledResource result = apiInstance.ListAccessControlledResources();
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ApplicationMetadataApi.ListAccessControlledResources: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```


## Endpoints and models

- See [Documentation for API Endpoints](sdk/README.md#documentation-for-api-endpoints) for a description of each endpoint
- See [Documentation for Models](sdk/README.md#documentation-for-models) for descriptions of the models used

