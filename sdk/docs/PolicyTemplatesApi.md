# Finbourne.Access.Sdk.Api.PolicyTemplatesApi

All URIs are relative to *https://fbn-prd.lusid.com/access*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreatePolicyTemplate**](PolicyTemplatesApi.md#createpolicytemplate) | **POST** /api/policytemplates | [EXPERIMENTAL] CreatePolicyTemplate: Create a Policy Template |
| [**DeletePolicyTemplate**](PolicyTemplatesApi.md#deletepolicytemplate) | **DELETE** /api/policytemplates/{code} | [EXPERIMENTAL] DeletePolicyTemplate: Deleting a policy template |
| [**GeneratePolicyFromTemplate**](PolicyTemplatesApi.md#generatepolicyfromtemplate) | **POST** /api/policytemplates/$generatepolicy | [EXPERIMENTAL] GeneratePolicyFromTemplate: Generate policy from template |
| [**GetPolicyTemplate**](PolicyTemplatesApi.md#getpolicytemplate) | **GET** /api/policytemplates/{code} | [EXPERIMENTAL] GetPolicyTemplate: Retrieving one Policy Template |
| [**ListPolicyTemplates**](PolicyTemplatesApi.md#listpolicytemplates) | **GET** /api/policytemplates | [EXPERIMENTAL] ListPolicyTemplates: List Policy Templates |
| [**UpdatePolicyTemplate**](PolicyTemplatesApi.md#updatepolicytemplate) | **PUT** /api/policytemplates/{code} | [EXPERIMENTAL] UpdatePolicyTemplate: Update a Policy Template |

<a id="createpolicytemplate"></a>
# **CreatePolicyTemplate**
> PolicyTemplateResponse CreatePolicyTemplate (PolicyTemplateCreationRequest policyTemplateCreationRequest)

[EXPERIMENTAL] CreatePolicyTemplate: Create a Policy Template

Creates a Policy Template

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PolicyTemplatesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PolicyTemplatesApi>();
            var policyTemplateCreationRequest = new PolicyTemplateCreationRequest(); // PolicyTemplateCreationRequest | The definition of the policy template

            try
            {
                // uncomment the below to set overrides at the request level
                // PolicyTemplateResponse result = apiInstance.CreatePolicyTemplate(policyTemplateCreationRequest, opts: opts);

                // [EXPERIMENTAL] CreatePolicyTemplate: Create a Policy Template
                PolicyTemplateResponse result = apiInstance.CreatePolicyTemplate(policyTemplateCreationRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PolicyTemplatesApi.CreatePolicyTemplate: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePolicyTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreatePolicyTemplate: Create a Policy Template
    ApiResponse<PolicyTemplateResponse> response = apiInstance.CreatePolicyTemplateWithHttpInfo(policyTemplateCreationRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PolicyTemplatesApi.CreatePolicyTemplateWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **policyTemplateCreationRequest** | [**PolicyTemplateCreationRequest**](PolicyTemplateCreationRequest.md) | The definition of the policy template |  |

### Return type

[**PolicyTemplateResponse**](PolicyTemplateResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created Policy Template |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletepolicytemplate"></a>
# **DeletePolicyTemplate**
> void DeletePolicyTemplate (string code, string? scope = null)

[EXPERIMENTAL] DeletePolicyTemplate: Deleting a policy template

Deletes an identified Policy Template

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PolicyTemplatesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PolicyTemplatesApi>();
            var code = "code_example";  // string | The code of the Policy Template
            var scope = "scope_example";  // string? | Optional. Will use the default scope if not provided. The scope of the Policy Template (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // apiInstance.DeletePolicyTemplate(code, scope, opts: opts);

                // [EXPERIMENTAL] DeletePolicyTemplate: Deleting a policy template
                apiInstance.DeletePolicyTemplate(code, scope);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PolicyTemplatesApi.DeletePolicyTemplate: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePolicyTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeletePolicyTemplate: Deleting a policy template
    apiInstance.DeletePolicyTemplateWithHttpInfo(code, scope);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PolicyTemplatesApi.DeletePolicyTemplateWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | The code of the Policy Template |  |
| **scope** | **string?** | Optional. Will use the default scope if not provided. The scope of the Policy Template | [optional]  |

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="generatepolicyfromtemplate"></a>
# **GeneratePolicyFromTemplate**
> GeneratedPolicyComponents GeneratePolicyFromTemplate (GeneratePolicyFromTemplateRequest generatePolicyFromTemplateRequest, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GeneratePolicyFromTemplate: Generate policy from template

Generates policies from templates

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PolicyTemplatesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PolicyTemplatesApi>();
            var generatePolicyFromTemplateRequest = new GeneratePolicyFromTemplateRequest(); // GeneratePolicyFromTemplateRequest | Definition of the generate request
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Optional. The AsAt date time of the data (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // GeneratedPolicyComponents result = apiInstance.GeneratePolicyFromTemplate(generatePolicyFromTemplateRequest, asAt, opts: opts);

                // [EXPERIMENTAL] GeneratePolicyFromTemplate: Generate policy from template
                GeneratedPolicyComponents result = apiInstance.GeneratePolicyFromTemplate(generatePolicyFromTemplateRequest, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PolicyTemplatesApi.GeneratePolicyFromTemplate: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GeneratePolicyFromTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GeneratePolicyFromTemplate: Generate policy from template
    ApiResponse<GeneratedPolicyComponents> response = apiInstance.GeneratePolicyFromTemplateWithHttpInfo(generatePolicyFromTemplateRequest, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PolicyTemplatesApi.GeneratePolicyFromTemplateWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **generatePolicyFromTemplateRequest** | [**GeneratePolicyFromTemplateRequest**](GeneratePolicyFromTemplateRequest.md) | Definition of the generate request |  |
| **asAt** | **DateTimeOffset?** | Optional. The AsAt date time of the data | [optional]  |

### Return type

[**GeneratedPolicyComponents**](GeneratedPolicyComponents.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getpolicytemplate"></a>
# **GetPolicyTemplate**
> PolicyTemplateResponse GetPolicyTemplate (string code, DateTimeOffset? asAt = null, string? scope = null)

[EXPERIMENTAL] GetPolicyTemplate: Retrieving one Policy Template

Gets an identified Policy Template

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PolicyTemplatesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PolicyTemplatesApi>();
            var code = "code_example";  // string | The code of the Policy Template
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Optional. The AsAt date time of the data. If not specified defaults to current time (optional) 
            var scope = "scope_example";  // string? | Optional. Will use the default scope if not provided. The scope of the Policy Template (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PolicyTemplateResponse result = apiInstance.GetPolicyTemplate(code, asAt, scope, opts: opts);

                // [EXPERIMENTAL] GetPolicyTemplate: Retrieving one Policy Template
                PolicyTemplateResponse result = apiInstance.GetPolicyTemplate(code, asAt, scope);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PolicyTemplatesApi.GetPolicyTemplate: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPolicyTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetPolicyTemplate: Retrieving one Policy Template
    ApiResponse<PolicyTemplateResponse> response = apiInstance.GetPolicyTemplateWithHttpInfo(code, asAt, scope);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PolicyTemplatesApi.GetPolicyTemplateWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | The code of the Policy Template |  |
| **asAt** | **DateTimeOffset?** | Optional. The AsAt date time of the data. If not specified defaults to current time | [optional]  |
| **scope** | **string?** | Optional. Will use the default scope if not provided. The scope of the Policy Template | [optional]  |

### Return type

[**PolicyTemplateResponse**](PolicyTemplateResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Get a specific Policy Template |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listpolicytemplates"></a>
# **ListPolicyTemplates**
> ResourceListOfPolicyTemplateResponse ListPolicyTemplates (DateTimeOffset? asAt = null, string? sortBy = null, int? limit = null, string? filter = null, string? page = null)

[EXPERIMENTAL] ListPolicyTemplates: List Policy Templates

Gets all Policy Templates with pagination support.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PolicyTemplatesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PolicyTemplatesApi>();
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Optional. The AsAt date time of the data (optional) 
            var sortBy = "sortBy_example";  // string? | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var filter = "filter_example";  // string? | Optional. Expression to filter the result set (optional) 
            var page = "page_example";  // string? | Optional. Paging token returned from a previous result (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfPolicyTemplateResponse result = apiInstance.ListPolicyTemplates(asAt, sortBy, limit, filter, page, opts: opts);

                // [EXPERIMENTAL] ListPolicyTemplates: List Policy Templates
                ResourceListOfPolicyTemplateResponse result = apiInstance.ListPolicyTemplates(asAt, sortBy, limit, filter, page);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PolicyTemplatesApi.ListPolicyTemplates: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListPolicyTemplatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListPolicyTemplates: List Policy Templates
    ApiResponse<ResourceListOfPolicyTemplateResponse> response = apiInstance.ListPolicyTemplatesWithHttpInfo(asAt, sortBy, limit, filter, page);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PolicyTemplatesApi.ListPolicyTemplatesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | Optional. The AsAt date time of the data | [optional]  |
| **sortBy** | **string?** | Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional]  |
| **limit** | **int?** | Optional. When paginating, limit the number of returned results to this many. | [optional]  |
| **filter** | **string?** | Optional. Expression to filter the result set | [optional]  |
| **page** | **string?** | Optional. Paging token returned from a previous result | [optional]  |

### Return type

[**ResourceListOfPolicyTemplateResponse**](ResourceListOfPolicyTemplateResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List Policy Templates |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updatepolicytemplate"></a>
# **UpdatePolicyTemplate**
> PolicyTemplateResponse UpdatePolicyTemplate (string code, PolicyTemplateUpdateRequest? policyTemplateUpdateRequest = null)

[EXPERIMENTAL] UpdatePolicyTemplate: Update a Policy Template

Updates an identified Policy Template

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PolicyTemplatesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PolicyTemplatesApi>();
            var code = "code_example";  // string | Code of the policy template to update
            var policyTemplateUpdateRequest = new PolicyTemplateUpdateRequest?(); // PolicyTemplateUpdateRequest? | Definition of the updated policy template (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PolicyTemplateResponse result = apiInstance.UpdatePolicyTemplate(code, policyTemplateUpdateRequest, opts: opts);

                // [EXPERIMENTAL] UpdatePolicyTemplate: Update a Policy Template
                PolicyTemplateResponse result = apiInstance.UpdatePolicyTemplate(code, policyTemplateUpdateRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PolicyTemplatesApi.UpdatePolicyTemplate: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdatePolicyTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpdatePolicyTemplate: Update a Policy Template
    ApiResponse<PolicyTemplateResponse> response = apiInstance.UpdatePolicyTemplateWithHttpInfo(code, policyTemplateUpdateRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PolicyTemplatesApi.UpdatePolicyTemplateWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | Code of the policy template to update |  |
| **policyTemplateUpdateRequest** | [**PolicyTemplateUpdateRequest?**](PolicyTemplateUpdateRequest?.md) | Definition of the updated policy template | [optional]  |

### Return type

[**PolicyTemplateResponse**](PolicyTemplateResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated Policy Template |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

