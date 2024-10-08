# Finbourne.Access.Sdk.Api.PoliciesApi

All URIs are relative to *https://fbn-prd.lusid.com/access*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddToPolicyCollection**](PoliciesApi.md#addtopolicycollection) | **POST** /api/policycollections/{code}/add | AddToPolicyCollection: Add To PolicyCollection |
| [**CreatePolicy**](PoliciesApi.md#createpolicy) | **POST** /api/policies | CreatePolicy: Create Policy |
| [**CreatePolicyCollection**](PoliciesApi.md#createpolicycollection) | **POST** /api/policycollections | CreatePolicyCollection: Create PolicyCollection |
| [**DeletePolicy**](PoliciesApi.md#deletepolicy) | **DELETE** /api/policies/{code} | DeletePolicy: Delete Policy |
| [**DeletePolicyCollection**](PoliciesApi.md#deletepolicycollection) | **DELETE** /api/policycollections/{code} | DeletePolicyCollection: Delete PolicyCollection |
| [**Evaluate**](PoliciesApi.md#evaluate) | **POST** /api/me | Evaluate: Run one or more evaluations |
| [**GetOwnPolicies**](PoliciesApi.md#getownpolicies) | **GET** /api/me | GetOwnPolicies: Get policies of requesting user |
| [**GetPolicy**](PoliciesApi.md#getpolicy) | **GET** /api/policies/{code} | GetPolicy: Get Policy |
| [**GetPolicyCollection**](PoliciesApi.md#getpolicycollection) | **GET** /api/policycollections/{code} | GetPolicyCollection: Get PolicyCollection |
| [**ListPolicies**](PoliciesApi.md#listpolicies) | **GET** /api/policies | ListPolicies: List Policies |
| [**ListPolicyCollections**](PoliciesApi.md#listpolicycollections) | **GET** /api/policycollections | ListPolicyCollections: List PolicyCollections |
| [**PagePolicies**](PoliciesApi.md#pagepolicies) | **GET** /api/policies/page | PagePolicies: Page Policies |
| [**PagePolicyCollections**](PoliciesApi.md#pagepolicycollections) | **GET** /api/policycollections/page | PagePolicyCollections: Page PolicyCollections |
| [**RemoveFromPolicyCollection**](PoliciesApi.md#removefrompolicycollection) | **POST** /api/policycollections/{code}/remove | RemoveFromPolicyCollection: Remove From PolicyCollection |
| [**UpdatePolicy**](PoliciesApi.md#updatepolicy) | **PUT** /api/policies/{code} | UpdatePolicy: Update Policy |
| [**UpdatePolicyCollection**](PoliciesApi.md#updatepolicycollection) | **PUT** /api/policycollections/{code} | UpdatePolicyCollection: Update PolicyCollection |

<a id="addtopolicycollection"></a>
# **AddToPolicyCollection**
> PolicyCollectionResponse AddToPolicyCollection (string code, AddToPolicyCollectionRequest addToPolicyCollectionRequest, string? scope = null)

AddToPolicyCollection: Add To PolicyCollection

Add Policies and/or PolicyCollections to a PolicyCollection

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PoliciesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PoliciesApi>();
            var code = "code_example";  // string | The code of the PolicyCollection
            var addToPolicyCollectionRequest = new AddToPolicyCollectionRequest(); // AddToPolicyCollectionRequest | Ids of the PolicyCollections and/or Policies to add to the PolicyCollection
            var scope = "scope_example";  // string? | Optional. Will use the default scope if not provided. The scope of the PolicyCollection (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PolicyCollectionResponse result = apiInstance.AddToPolicyCollection(code, addToPolicyCollectionRequest, scope, opts: opts);

                // AddToPolicyCollection: Add To PolicyCollection
                PolicyCollectionResponse result = apiInstance.AddToPolicyCollection(code, addToPolicyCollectionRequest, scope);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PoliciesApi.AddToPolicyCollection: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddToPolicyCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // AddToPolicyCollection: Add To PolicyCollection
    ApiResponse<PolicyCollectionResponse> response = apiInstance.AddToPolicyCollectionWithHttpInfo(code, addToPolicyCollectionRequest, scope);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PoliciesApi.AddToPolicyCollectionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | The code of the PolicyCollection |  |
| **addToPolicyCollectionRequest** | [**AddToPolicyCollectionRequest**](AddToPolicyCollectionRequest.md) | Ids of the PolicyCollections and/or Policies to add to the PolicyCollection |  |
| **scope** | **string?** | Optional. Will use the default scope if not provided. The scope of the PolicyCollection | [optional]  |

### Return type

[**PolicyCollectionResponse**](PolicyCollectionResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated PolicyCollection |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="createpolicy"></a>
# **CreatePolicy**
> PolicyResponse CreatePolicy (PolicyCreationRequest policyCreationRequest)

CreatePolicy: Create Policy

Creates a Policy

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PoliciesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PoliciesApi>();
            var policyCreationRequest = new PolicyCreationRequest(); // PolicyCreationRequest | The definition of the Policy

            try
            {
                // uncomment the below to set overrides at the request level
                // PolicyResponse result = apiInstance.CreatePolicy(policyCreationRequest, opts: opts);

                // CreatePolicy: Create Policy
                PolicyResponse result = apiInstance.CreatePolicy(policyCreationRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PoliciesApi.CreatePolicy: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePolicyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CreatePolicy: Create Policy
    ApiResponse<PolicyResponse> response = apiInstance.CreatePolicyWithHttpInfo(policyCreationRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PoliciesApi.CreatePolicyWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **policyCreationRequest** | [**PolicyCreationRequest**](PolicyCreationRequest.md) | The definition of the Policy |  |

### Return type

[**PolicyResponse**](PolicyResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created policy |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="createpolicycollection"></a>
# **CreatePolicyCollection**
> PolicyCollectionResponse CreatePolicyCollection (PolicyCollectionCreationRequest policyCollectionCreationRequest)

CreatePolicyCollection: Create PolicyCollection

Creates a PolicyCollection

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PoliciesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PoliciesApi>();
            var policyCollectionCreationRequest = new PolicyCollectionCreationRequest(); // PolicyCollectionCreationRequest | The definition of the PolicyCollection

            try
            {
                // uncomment the below to set overrides at the request level
                // PolicyCollectionResponse result = apiInstance.CreatePolicyCollection(policyCollectionCreationRequest, opts: opts);

                // CreatePolicyCollection: Create PolicyCollection
                PolicyCollectionResponse result = apiInstance.CreatePolicyCollection(policyCollectionCreationRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PoliciesApi.CreatePolicyCollection: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePolicyCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CreatePolicyCollection: Create PolicyCollection
    ApiResponse<PolicyCollectionResponse> response = apiInstance.CreatePolicyCollectionWithHttpInfo(policyCollectionCreationRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PoliciesApi.CreatePolicyCollectionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **policyCollectionCreationRequest** | [**PolicyCollectionCreationRequest**](PolicyCollectionCreationRequest.md) | The definition of the PolicyCollection |  |

### Return type

[**PolicyCollectionResponse**](PolicyCollectionResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created PolicyCollection |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletepolicy"></a>
# **DeletePolicy**
> void DeletePolicy (string code, string? scope = null)

DeletePolicy: Delete Policy

Deletes an identified Policy

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PoliciesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PoliciesApi>();
            var code = "code_example";  // string | The code of the Policy
            var scope = "scope_example";  // string? | Optional. Will use the default scope if not provided. The scope of the Policy (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // apiInstance.DeletePolicy(code, scope, opts: opts);

                // DeletePolicy: Delete Policy
                apiInstance.DeletePolicy(code, scope);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PoliciesApi.DeletePolicy: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePolicyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DeletePolicy: Delete Policy
    apiInstance.DeletePolicyWithHttpInfo(code, scope);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PoliciesApi.DeletePolicyWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | The code of the Policy |  |
| **scope** | **string?** | Optional. Will use the default scope if not provided. The scope of the Policy | [optional]  |

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

<a id="deletepolicycollection"></a>
# **DeletePolicyCollection**
> void DeletePolicyCollection (string code, string? scope = null)

DeletePolicyCollection: Delete PolicyCollection

Deletes an identified PolicyCollection

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PoliciesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PoliciesApi>();
            var code = "code_example";  // string | The code of the PolicyCollection
            var scope = "scope_example";  // string? | Optional. Will use the default scope if not provided. The scope of the PolicyCollection (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // apiInstance.DeletePolicyCollection(code, scope, opts: opts);

                // DeletePolicyCollection: Delete PolicyCollection
                apiInstance.DeletePolicyCollection(code, scope);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PoliciesApi.DeletePolicyCollection: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePolicyCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DeletePolicyCollection: Delete PolicyCollection
    apiInstance.DeletePolicyCollectionWithHttpInfo(code, scope);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PoliciesApi.DeletePolicyCollectionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | The code of the PolicyCollection |  |
| **scope** | **string?** | Optional. Will use the default scope if not provided. The scope of the PolicyCollection | [optional]  |

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

<a id="evaluate"></a>
# **Evaluate**
> Dictionary&lt;string, EvaluationResponse&gt; Evaluate (Dictionary<string, EvaluationRequest> requestBody, List<string>? applications = null)

Evaluate: Run one or more evaluations

Given a dictionary of evaluation requests (keyed by any arbitrary correlation identifier), each will be evaluated according to the current user's policies (deduced from the provided OAuth token).

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PoliciesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PoliciesApi>();
            var requestBody = new Dictionary<string, EvaluationRequest>(); // Dictionary<string, EvaluationRequest> | A dictionary of evaluations, keyed using any arbitrary correlation id (it will be returned with the response for that evaluation).
            var applications = new List<string>?(); // List<string>? | Optional. The application type of the roles and policies to use when evaluating. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // Dictionary<string, EvaluationResponse> result = apiInstance.Evaluate(requestBody, applications, opts: opts);

                // Evaluate: Run one or more evaluations
                Dictionary<string, EvaluationResponse> result = apiInstance.Evaluate(requestBody, applications);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PoliciesApi.Evaluate: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the EvaluateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Evaluate: Run one or more evaluations
    ApiResponse<Dictionary<string, EvaluationResponse>> response = apiInstance.EvaluateWithHttpInfo(requestBody, applications);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PoliciesApi.EvaluateWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**Dictionary&lt;string, EvaluationRequest&gt;**](EvaluationRequest.md) | A dictionary of evaluations, keyed using any arbitrary correlation id (it will be returned with the response for that evaluation). |  |
| **applications** | [**List&lt;string&gt;?**](string.md) | Optional. The application type of the roles and policies to use when evaluating. | [optional]  |

### Return type

[**Dictionary&lt;string, EvaluationResponse&gt;**](EvaluationResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Run an evaluation against the current user&#39;s entitlements |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getownpolicies"></a>
# **GetOwnPolicies**
> List&lt;AttachedPolicyDefinitionResponse&gt; GetOwnPolicies (List<string>? applications = null)

GetOwnPolicies: Get policies of requesting user

Gets all Policies for the current user

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PoliciesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PoliciesApi>();
            var applications = new List<string>?(); // List<string>? | Optional. Filter on the applications that the policies apply to (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // List<AttachedPolicyDefinitionResponse> result = apiInstance.GetOwnPolicies(applications, opts: opts);

                // GetOwnPolicies: Get policies of requesting user
                List<AttachedPolicyDefinitionResponse> result = apiInstance.GetOwnPolicies(applications);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PoliciesApi.GetOwnPolicies: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOwnPoliciesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetOwnPolicies: Get policies of requesting user
    ApiResponse<List<AttachedPolicyDefinitionResponse>> response = apiInstance.GetOwnPoliciesWithHttpInfo(applications);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PoliciesApi.GetOwnPoliciesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applications** | [**List&lt;string&gt;?**](string.md) | Optional. Filter on the applications that the policies apply to | [optional]  |

### Return type

[**List&lt;AttachedPolicyDefinitionResponse&gt;**](AttachedPolicyDefinitionResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Get policies and licences of current user |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getpolicy"></a>
# **GetPolicy**
> PolicyResponse GetPolicy (string code, string? scope = null)

GetPolicy: Get Policy

Gets an identified Policy

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PoliciesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PoliciesApi>();
            var code = "code_example";  // string | The code of the Policy
            var scope = "scope_example";  // string? | Optional. Will use the default scope if not provided. The scope of the Policy (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PolicyResponse result = apiInstance.GetPolicy(code, scope, opts: opts);

                // GetPolicy: Get Policy
                PolicyResponse result = apiInstance.GetPolicy(code, scope);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PoliciesApi.GetPolicy: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPolicyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetPolicy: Get Policy
    ApiResponse<PolicyResponse> response = apiInstance.GetPolicyWithHttpInfo(code, scope);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PoliciesApi.GetPolicyWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | The code of the Policy |  |
| **scope** | **string?** | Optional. Will use the default scope if not provided. The scope of the Policy | [optional]  |

### Return type

[**PolicyResponse**](PolicyResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Get a specific Policy |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getpolicycollection"></a>
# **GetPolicyCollection**
> PolicyCollectionResponse GetPolicyCollection (string code, string? scope = null)

GetPolicyCollection: Get PolicyCollection

Gets an identified PolicyCollection

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PoliciesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PoliciesApi>();
            var code = "code_example";  // string | The code of the PolicyCollection
            var scope = "scope_example";  // string? | Optional. Will use the default scope if not provided. The scope of the PolicyCollection (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PolicyCollectionResponse result = apiInstance.GetPolicyCollection(code, scope, opts: opts);

                // GetPolicyCollection: Get PolicyCollection
                PolicyCollectionResponse result = apiInstance.GetPolicyCollection(code, scope);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PoliciesApi.GetPolicyCollection: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPolicyCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetPolicyCollection: Get PolicyCollection
    ApiResponse<PolicyCollectionResponse> response = apiInstance.GetPolicyCollectionWithHttpInfo(code, scope);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PoliciesApi.GetPolicyCollectionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | The code of the PolicyCollection |  |
| **scope** | **string?** | Optional. Will use the default scope if not provided. The scope of the PolicyCollection | [optional]  |

### Return type

[**PolicyCollectionResponse**](PolicyCollectionResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Requested PolicyCollection |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listpolicies"></a>
# **ListPolicies**
> List&lt;PolicyResponse&gt; ListPolicies (string? scope = null)

ListPolicies: List Policies

Gets all Policies in a scope. For pagination support, use PagePolicies.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PoliciesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PoliciesApi>();
            var scope = "scope_example";  // string? | Optional. Will use the default scope if not provided. The requested scope (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // List<PolicyResponse> result = apiInstance.ListPolicies(scope, opts: opts);

                // ListPolicies: List Policies
                List<PolicyResponse> result = apiInstance.ListPolicies(scope);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PoliciesApi.ListPolicies: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListPoliciesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListPolicies: List Policies
    ApiResponse<List<PolicyResponse>> response = apiInstance.ListPoliciesWithHttpInfo(scope);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PoliciesApi.ListPoliciesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string?** | Optional. Will use the default scope if not provided. The requested scope | [optional]  |

### Return type

[**List&lt;PolicyResponse&gt;**](PolicyResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List Policies |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listpolicycollections"></a>
# **ListPolicyCollections**
> List&lt;PolicyCollectionResponse&gt; ListPolicyCollections (string? scope = null)

ListPolicyCollections: List PolicyCollections

Gets all PolicyCollections in a scope. For pagination support, use PagePolicyCollections

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PoliciesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PoliciesApi>();
            var scope = "scope_example";  // string? | Optional. Will use the default scope if not provided. The requested scope (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // List<PolicyCollectionResponse> result = apiInstance.ListPolicyCollections(scope, opts: opts);

                // ListPolicyCollections: List PolicyCollections
                List<PolicyCollectionResponse> result = apiInstance.ListPolicyCollections(scope);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PoliciesApi.ListPolicyCollections: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListPolicyCollectionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListPolicyCollections: List PolicyCollections
    ApiResponse<List<PolicyCollectionResponse>> response = apiInstance.ListPolicyCollectionsWithHttpInfo(scope);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PoliciesApi.ListPolicyCollectionsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string?** | Optional. Will use the default scope if not provided. The requested scope | [optional]  |

### Return type

[**List&lt;PolicyCollectionResponse&gt;**](PolicyCollectionResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Requested list of PolicyCollections |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="pagepolicies"></a>
# **PagePolicies**
> ResourceListOfPolicyResponse PagePolicies (string? sortBy = null, int? limit = null, string? filter = null, string? page = null)

PagePolicies: Page Policies

Gets all Policies with pagination support.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PoliciesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PoliciesApi>();
            var sortBy = "sortBy_example";  // string? | Optional. Order the results by these fields. Use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var limit = 56;  // int? | Optional. 2000 if not provided. When paginating, limit the number of returned results to this many (optional) 
            var filter = "filter_example";  // string? | Optional. Expression to filter the result set (optional) 
            var page = "page_example";  // string? | Optional. Paging token returned from a previous result (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfPolicyResponse result = apiInstance.PagePolicies(sortBy, limit, filter, page, opts: opts);

                // PagePolicies: Page Policies
                ResourceListOfPolicyResponse result = apiInstance.PagePolicies(sortBy, limit, filter, page);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PoliciesApi.PagePolicies: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the PagePoliciesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PagePolicies: Page Policies
    ApiResponse<ResourceListOfPolicyResponse> response = apiInstance.PagePoliciesWithHttpInfo(sortBy, limit, filter, page);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PoliciesApi.PagePoliciesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sortBy** | **string?** | Optional. Order the results by these fields. Use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional]  |
| **limit** | **int?** | Optional. 2000 if not provided. When paginating, limit the number of returned results to this many | [optional]  |
| **filter** | **string?** | Optional. Expression to filter the result set | [optional]  |
| **page** | **string?** | Optional. Paging token returned from a previous result | [optional]  |

### Return type

[**ResourceListOfPolicyResponse**](ResourceListOfPolicyResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Requested list of Policies |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="pagepolicycollections"></a>
# **PagePolicyCollections**
> ResourceListOfPolicyCollectionResponse PagePolicyCollections (string? sortBy = null, int? limit = null, string? filter = null, string? page = null)

PagePolicyCollections: Page PolicyCollections

Gets all PolicyCollections with pagination support.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PoliciesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PoliciesApi>();
            var sortBy = "sortBy_example";  // string? | Optional. Order the results by these fields. Use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var limit = 56;  // int? | Optional. 2000 if not provided. When paginating, limit the number of returned results to this many (optional) 
            var filter = "filter_example";  // string? | Optional. Expression to filter the result set (optional) 
            var page = "page_example";  // string? | Optional. Paging token returned from a previous result (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfPolicyCollectionResponse result = apiInstance.PagePolicyCollections(sortBy, limit, filter, page, opts: opts);

                // PagePolicyCollections: Page PolicyCollections
                ResourceListOfPolicyCollectionResponse result = apiInstance.PagePolicyCollections(sortBy, limit, filter, page);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PoliciesApi.PagePolicyCollections: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the PagePolicyCollectionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PagePolicyCollections: Page PolicyCollections
    ApiResponse<ResourceListOfPolicyCollectionResponse> response = apiInstance.PagePolicyCollectionsWithHttpInfo(sortBy, limit, filter, page);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PoliciesApi.PagePolicyCollectionsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sortBy** | **string?** | Optional. Order the results by these fields. Use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional]  |
| **limit** | **int?** | Optional. 2000 if not provided. When paginating, limit the number of returned results to this many | [optional]  |
| **filter** | **string?** | Optional. Expression to filter the result set | [optional]  |
| **page** | **string?** | Optional. Paging token returned from a previous result | [optional]  |

### Return type

[**ResourceListOfPolicyCollectionResponse**](ResourceListOfPolicyCollectionResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Requested list of PolicyCollections |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="removefrompolicycollection"></a>
# **RemoveFromPolicyCollection**
> PolicyCollectionResponse RemoveFromPolicyCollection (string code, RemoveFromPolicyCollectionRequest removeFromPolicyCollectionRequest, string? scope = null)

RemoveFromPolicyCollection: Remove From PolicyCollection

Remove Policies and/or PolicyCollections from a PolicyCollection

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PoliciesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PoliciesApi>();
            var code = "code_example";  // string | The code of the PolicyCollection
            var removeFromPolicyCollectionRequest = new RemoveFromPolicyCollectionRequest(); // RemoveFromPolicyCollectionRequest | Ids of the PolicyCollections and/or Policies to remove from the PolicyCollection
            var scope = "scope_example";  // string? | Optional. Will use the default scope if not provided. The scope of the PolicyCollection (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PolicyCollectionResponse result = apiInstance.RemoveFromPolicyCollection(code, removeFromPolicyCollectionRequest, scope, opts: opts);

                // RemoveFromPolicyCollection: Remove From PolicyCollection
                PolicyCollectionResponse result = apiInstance.RemoveFromPolicyCollection(code, removeFromPolicyCollectionRequest, scope);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PoliciesApi.RemoveFromPolicyCollection: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveFromPolicyCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // RemoveFromPolicyCollection: Remove From PolicyCollection
    ApiResponse<PolicyCollectionResponse> response = apiInstance.RemoveFromPolicyCollectionWithHttpInfo(code, removeFromPolicyCollectionRequest, scope);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PoliciesApi.RemoveFromPolicyCollectionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | The code of the PolicyCollection |  |
| **removeFromPolicyCollectionRequest** | [**RemoveFromPolicyCollectionRequest**](RemoveFromPolicyCollectionRequest.md) | Ids of the PolicyCollections and/or Policies to remove from the PolicyCollection |  |
| **scope** | **string?** | Optional. Will use the default scope if not provided. The scope of the PolicyCollection | [optional]  |

### Return type

[**PolicyCollectionResponse**](PolicyCollectionResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated PolicyCollection |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updatepolicy"></a>
# **UpdatePolicy**
> PolicyResponse UpdatePolicy (string code, PolicyUpdateRequest policyUpdateRequest, string? scope = null)

UpdatePolicy: Update Policy

Updates a Policy

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PoliciesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PoliciesApi>();
            var code = "code_example";  // string | The code of the Policy
            var policyUpdateRequest = new PolicyUpdateRequest(); // PolicyUpdateRequest | The updated definition of the Policy
            var scope = "scope_example";  // string? | Optional. Will use the default scope if not provided. The scope of the Policy (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PolicyResponse result = apiInstance.UpdatePolicy(code, policyUpdateRequest, scope, opts: opts);

                // UpdatePolicy: Update Policy
                PolicyResponse result = apiInstance.UpdatePolicy(code, policyUpdateRequest, scope);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PoliciesApi.UpdatePolicy: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdatePolicyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // UpdatePolicy: Update Policy
    ApiResponse<PolicyResponse> response = apiInstance.UpdatePolicyWithHttpInfo(code, policyUpdateRequest, scope);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PoliciesApi.UpdatePolicyWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | The code of the Policy |  |
| **policyUpdateRequest** | [**PolicyUpdateRequest**](PolicyUpdateRequest.md) | The updated definition of the Policy |  |
| **scope** | **string?** | Optional. Will use the default scope if not provided. The scope of the Policy | [optional]  |

### Return type

[**PolicyResponse**](PolicyResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated policy |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updatepolicycollection"></a>
# **UpdatePolicyCollection**
> PolicyCollectionResponse UpdatePolicyCollection (string code, PolicyCollectionUpdateRequest policyCollectionUpdateRequest, string? scope = null)

UpdatePolicyCollection: Update PolicyCollection

Updates a PolicyCollection

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PoliciesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PoliciesApi>();
            var code = "code_example";  // string | The code of the PolicyCollection
            var policyCollectionUpdateRequest = new PolicyCollectionUpdateRequest(); // PolicyCollectionUpdateRequest | The updated definition of the PolicyCollection
            var scope = "scope_example";  // string? | Optional. Will use the default scope if not provided. The scope of the PolicyCollection (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PolicyCollectionResponse result = apiInstance.UpdatePolicyCollection(code, policyCollectionUpdateRequest, scope, opts: opts);

                // UpdatePolicyCollection: Update PolicyCollection
                PolicyCollectionResponse result = apiInstance.UpdatePolicyCollection(code, policyCollectionUpdateRequest, scope);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PoliciesApi.UpdatePolicyCollection: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdatePolicyCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // UpdatePolicyCollection: Update PolicyCollection
    ApiResponse<PolicyCollectionResponse> response = apiInstance.UpdatePolicyCollectionWithHttpInfo(code, policyCollectionUpdateRequest, scope);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PoliciesApi.UpdatePolicyCollectionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | The code of the PolicyCollection |  |
| **policyCollectionUpdateRequest** | [**PolicyCollectionUpdateRequest**](PolicyCollectionUpdateRequest.md) | The updated definition of the PolicyCollection |  |
| **scope** | **string?** | Optional. Will use the default scope if not provided. The scope of the PolicyCollection | [optional]  |

### Return type

[**PolicyCollectionResponse**](PolicyCollectionResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated PolicyCollection |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

