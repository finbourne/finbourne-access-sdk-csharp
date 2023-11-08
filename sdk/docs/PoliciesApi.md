# Finbourne.Access.Sdk.Api.PoliciesApi

All URIs are relative to *https://fbn-prd.lusid.com/access*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddToPolicyCollection**](PoliciesApi.md#addtopolicycollection) | **POST** /api/policycollections/{code}/add | [EARLY ACCESS] AddToPolicyCollection: Add To PolicyCollection |
| [**CreatePolicy**](PoliciesApi.md#createpolicy) | **POST** /api/policies | [EARLY ACCESS] CreatePolicy: Create Policy |
| [**CreatePolicyCollection**](PoliciesApi.md#createpolicycollection) | **POST** /api/policycollections | [EARLY ACCESS] CreatePolicyCollection: Create PolicyCollection |
| [**DeletePolicy**](PoliciesApi.md#deletepolicy) | **DELETE** /api/policies/{code} | [EARLY ACCESS] DeletePolicy: Delete Policy |
| [**DeletePolicyCollection**](PoliciesApi.md#deletepolicycollection) | **DELETE** /api/policycollections/{code} | [EARLY ACCESS] DeletePolicyCollection: Delete PolicyCollection |
| [**Evaluate**](PoliciesApi.md#evaluate) | **POST** /api/me | [EARLY ACCESS] Evaluate: Run one or more evaluations |
| [**GetOwnPolicies**](PoliciesApi.md#getownpolicies) | **GET** /api/me | GetOwnPolicies: Get policies of requesting user |
| [**GetPolicy**](PoliciesApi.md#getpolicy) | **GET** /api/policies/{code} | [EARLY ACCESS] GetPolicy: Get Policy |
| [**GetPolicyCollection**](PoliciesApi.md#getpolicycollection) | **GET** /api/policycollections/{code} | [EARLY ACCESS] GetPolicyCollection: Get PolicyCollection |
| [**ListPolicies**](PoliciesApi.md#listpolicies) | **GET** /api/policies | [EARLY ACCESS] ListPolicies: List Policies |
| [**ListPolicyCollections**](PoliciesApi.md#listpolicycollections) | **GET** /api/policycollections | [EARLY ACCESS] ListPolicyCollections: List PolicyCollections |
| [**PagePolicies**](PoliciesApi.md#pagepolicies) | **GET** /api/policies/page | [EARLY ACCESS] PagePolicies: Page Policies |
| [**PagePolicyCollections**](PoliciesApi.md#pagepolicycollections) | **GET** /api/policycollections/page | [EARLY ACCESS] PagePolicyCollections: Page PolicyCollections |
| [**RemoveFromPolicyCollection**](PoliciesApi.md#removefrompolicycollection) | **POST** /api/policycollections/{code}/remove | [EARLY ACCESS] RemoveFromPolicyCollection: Remove From PolicyCollection |
| [**UpdatePolicy**](PoliciesApi.md#updatepolicy) | **PUT** /api/policies/{code} | [EARLY ACCESS] UpdatePolicy: Update Policy |
| [**UpdatePolicyCollection**](PoliciesApi.md#updatepolicycollection) | **PUT** /api/policycollections/{code} | [EARLY ACCESS] UpdatePolicyCollection: Update PolicyCollection |

<a id="addtopolicycollection"></a>
# **AddToPolicyCollection**
> PolicyCollectionResponse AddToPolicyCollection (string code, AddToPolicyCollectionRequest addToPolicyCollectionRequest, string? scope = null)

[EARLY ACCESS] AddToPolicyCollection: Add To PolicyCollection

Add Policies and/or PolicyCollections to a PolicyCollection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class AddToPolicyCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(config);
            var code = "code_example";  // string | The code of the PolicyCollection
            var addToPolicyCollectionRequest = new AddToPolicyCollectionRequest(); // AddToPolicyCollectionRequest | Ids of the PolicyCollections and/or Policies to add to the PolicyCollection
            var scope = "scope_example";  // string? | Optional. Will use the default scope if not provided. The scope of the PolicyCollection (optional) 

            try
            {
                // [EARLY ACCESS] AddToPolicyCollection: Add To PolicyCollection
                PolicyCollectionResponse result = apiInstance.AddToPolicyCollection(code, addToPolicyCollectionRequest, scope);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PoliciesApi.AddToPolicyCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // [EARLY ACCESS] AddToPolicyCollection: Add To PolicyCollection
    ApiResponse<PolicyCollectionResponse> response = apiInstance.AddToPolicyCollectionWithHttpInfo(code, addToPolicyCollectionRequest, scope);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PoliciesApi.AddToPolicyCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
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

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated PolicyCollection |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createpolicy"></a>
# **CreatePolicy**
> PolicyResponse CreatePolicy (PolicyCreationRequest policyCreationRequest)

[EARLY ACCESS] CreatePolicy: Create Policy

Creates a Policy

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class CreatePolicyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(config);
            var policyCreationRequest = new PolicyCreationRequest(); // PolicyCreationRequest | The definition of the Policy

            try
            {
                // [EARLY ACCESS] CreatePolicy: Create Policy
                PolicyResponse result = apiInstance.CreatePolicy(policyCreationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PoliciesApi.CreatePolicy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // [EARLY ACCESS] CreatePolicy: Create Policy
    ApiResponse<PolicyResponse> response = apiInstance.CreatePolicyWithHttpInfo(policyCreationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PoliciesApi.CreatePolicyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **policyCreationRequest** | [**PolicyCreationRequest**](PolicyCreationRequest.md) | The definition of the Policy |  |

### Return type

[**PolicyResponse**](PolicyResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created policy |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createpolicycollection"></a>
# **CreatePolicyCollection**
> PolicyCollectionResponse CreatePolicyCollection (PolicyCollectionCreationRequest policyCollectionCreationRequest)

[EARLY ACCESS] CreatePolicyCollection: Create PolicyCollection

Creates a PolicyCollection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class CreatePolicyCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(config);
            var policyCollectionCreationRequest = new PolicyCollectionCreationRequest(); // PolicyCollectionCreationRequest | The definition of the PolicyCollection

            try
            {
                // [EARLY ACCESS] CreatePolicyCollection: Create PolicyCollection
                PolicyCollectionResponse result = apiInstance.CreatePolicyCollection(policyCollectionCreationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PoliciesApi.CreatePolicyCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // [EARLY ACCESS] CreatePolicyCollection: Create PolicyCollection
    ApiResponse<PolicyCollectionResponse> response = apiInstance.CreatePolicyCollectionWithHttpInfo(policyCollectionCreationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PoliciesApi.CreatePolicyCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **policyCollectionCreationRequest** | [**PolicyCollectionCreationRequest**](PolicyCollectionCreationRequest.md) | The definition of the PolicyCollection |  |

### Return type

[**PolicyCollectionResponse**](PolicyCollectionResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created PolicyCollection |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletepolicy"></a>
# **DeletePolicy**
> void DeletePolicy (string code, string? scope = null)

[EARLY ACCESS] DeletePolicy: Delete Policy

Deletes an identified Policy

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class DeletePolicyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(config);
            var code = "code_example";  // string | The code of the Policy
            var scope = "scope_example";  // string? | Optional. Will use the default scope if not provided. The scope of the Policy (optional) 

            try
            {
                // [EARLY ACCESS] DeletePolicy: Delete Policy
                apiInstance.DeletePolicy(code, scope);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PoliciesApi.DeletePolicy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // [EARLY ACCESS] DeletePolicy: Delete Policy
    apiInstance.DeletePolicyWithHttpInfo(code, scope);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PoliciesApi.DeletePolicyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | The code of the Policy |  |
| **scope** | **string?** | Optional. Will use the default scope if not provided. The scope of the Policy | [optional]  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletepolicycollection"></a>
# **DeletePolicyCollection**
> void DeletePolicyCollection (string code, string? scope = null)

[EARLY ACCESS] DeletePolicyCollection: Delete PolicyCollection

Deletes an identified PolicyCollection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class DeletePolicyCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(config);
            var code = "code_example";  // string | The code of the PolicyCollection
            var scope = "scope_example";  // string? | Optional. Will use the default scope if not provided. The scope of the PolicyCollection (optional) 

            try
            {
                // [EARLY ACCESS] DeletePolicyCollection: Delete PolicyCollection
                apiInstance.DeletePolicyCollection(code, scope);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PoliciesApi.DeletePolicyCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // [EARLY ACCESS] DeletePolicyCollection: Delete PolicyCollection
    apiInstance.DeletePolicyCollectionWithHttpInfo(code, scope);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PoliciesApi.DeletePolicyCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | The code of the PolicyCollection |  |
| **scope** | **string?** | Optional. Will use the default scope if not provided. The scope of the PolicyCollection | [optional]  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="evaluate"></a>
# **Evaluate**
> Dictionary&lt;string, EvaluationResponse&gt; Evaluate (Dictionary<string, EvaluationRequest> requestBody, List<string>? applications = null, DateTimeOffset? asAt = null)

[EARLY ACCESS] Evaluate: Run one or more evaluations

Given a dictionary of evaluation requests (keyed by any arbitrary correlation identifier), each will be evaluated according to the current user's policies (deduced from the provided OAuth token).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class EvaluateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(config);
            var requestBody = new Dictionary<string, EvaluationRequest>(); // Dictionary<string, EvaluationRequest> | A dictionary of evaluations, keyed using any arbitrary correlation id (it will be returned with the response for that evaluation).
            var applications = new List<string>?(); // List<string>? | Optional. The application type of the roles and policies to use when evaluating. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Optional. The requested AsAt date of the entitlements (optional) 

            try
            {
                // [EARLY ACCESS] Evaluate: Run one or more evaluations
                Dictionary<string, EvaluationResponse> result = apiInstance.Evaluate(requestBody, applications, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PoliciesApi.Evaluate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // [EARLY ACCESS] Evaluate: Run one or more evaluations
    ApiResponse<Dictionary<string, EvaluationResponse>> response = apiInstance.EvaluateWithHttpInfo(requestBody, applications, asAt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PoliciesApi.EvaluateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**Dictionary&lt;string, EvaluationRequest&gt;**](EvaluationRequest.md) | A dictionary of evaluations, keyed using any arbitrary correlation id (it will be returned with the response for that evaluation). |  |
| **applications** | [**List&lt;string&gt;?**](string.md) | Optional. The application type of the roles and policies to use when evaluating. | [optional]  |
| **asAt** | **DateTimeOffset?** | Optional. The requested AsAt date of the entitlements | [optional]  |

### Return type

[**Dictionary&lt;string, EvaluationResponse&gt;**](EvaluationResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Run an evaluation against the current user&#39;s entitlements |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getownpolicies"></a>
# **GetOwnPolicies**
> List&lt;AttachedPolicyDefinitionResponse&gt; GetOwnPolicies (List<string>? applications = null, DateTimeOffset? asAt = null, List<string>? sortBy = null, int? start = null, int? limit = null, string? filter = null)

GetOwnPolicies: Get policies of requesting user

Gets all Policies for the current user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class GetOwnPoliciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(config);
            var applications = new List<string>?(); // List<string>? | Optional. Filter on the applications that the policies apply to (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Optional. The AsAt date time of the data (optional) 
            var sortBy = new List<string>?(); // List<string>? | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var filter = "filter_example";  // string? | Optional. Expression to filter the result set (optional) 

            try
            {
                // GetOwnPolicies: Get policies of requesting user
                List<AttachedPolicyDefinitionResponse> result = apiInstance.GetOwnPolicies(applications, asAt, sortBy, start, limit, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PoliciesApi.GetOwnPolicies: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    ApiResponse<List<AttachedPolicyDefinitionResponse>> response = apiInstance.GetOwnPoliciesWithHttpInfo(applications, asAt, sortBy, start, limit, filter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PoliciesApi.GetOwnPoliciesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applications** | [**List&lt;string&gt;?**](string.md) | Optional. Filter on the applications that the policies apply to | [optional]  |
| **asAt** | **DateTimeOffset?** | Optional. The AsAt date time of the data | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional]  |
| **start** | **int?** | Optional. When paginating, skip this number of results | [optional]  |
| **limit** | **int?** | Optional. When paginating, limit the number of returned results to this many. | [optional]  |
| **filter** | **string?** | Optional. Expression to filter the result set | [optional]  |

### Return type

[**List&lt;AttachedPolicyDefinitionResponse&gt;**](AttachedPolicyDefinitionResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Get policies and licences of current user |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpolicy"></a>
# **GetPolicy**
> PolicyResponse GetPolicy (string code, DateTimeOffset? asAt = null, string? scope = null)

[EARLY ACCESS] GetPolicy: Get Policy

Gets an identified Policy

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class GetPolicyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(config);
            var code = "code_example";  // string | The code of the Policy
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Optional. The AsAt date time of the data (optional) 
            var scope = "scope_example";  // string? | Optional. Will use the default scope if not provided. The scope of the Policy (optional) 

            try
            {
                // [EARLY ACCESS] GetPolicy: Get Policy
                PolicyResponse result = apiInstance.GetPolicy(code, asAt, scope);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PoliciesApi.GetPolicy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // [EARLY ACCESS] GetPolicy: Get Policy
    ApiResponse<PolicyResponse> response = apiInstance.GetPolicyWithHttpInfo(code, asAt, scope);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PoliciesApi.GetPolicyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | The code of the Policy |  |
| **asAt** | **DateTimeOffset?** | Optional. The AsAt date time of the data | [optional]  |
| **scope** | **string?** | Optional. Will use the default scope if not provided. The scope of the Policy | [optional]  |

### Return type

[**PolicyResponse**](PolicyResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Get a specific Policy |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpolicycollection"></a>
# **GetPolicyCollection**
> PolicyCollectionResponse GetPolicyCollection (string code, DateTimeOffset? asAt = null, string? scope = null)

[EARLY ACCESS] GetPolicyCollection: Get PolicyCollection

Gets an identified PolicyCollection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class GetPolicyCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(config);
            var code = "code_example";  // string | The code of the PolicyCollection
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Optional. The AsAt date time of the data (optional) 
            var scope = "scope_example";  // string? | Optional. Will use the default scope if not provided. The scope of the PolicyCollection (optional) 

            try
            {
                // [EARLY ACCESS] GetPolicyCollection: Get PolicyCollection
                PolicyCollectionResponse result = apiInstance.GetPolicyCollection(code, asAt, scope);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PoliciesApi.GetPolicyCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // [EARLY ACCESS] GetPolicyCollection: Get PolicyCollection
    ApiResponse<PolicyCollectionResponse> response = apiInstance.GetPolicyCollectionWithHttpInfo(code, asAt, scope);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PoliciesApi.GetPolicyCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | The code of the PolicyCollection |  |
| **asAt** | **DateTimeOffset?** | Optional. The AsAt date time of the data | [optional]  |
| **scope** | **string?** | Optional. Will use the default scope if not provided. The scope of the PolicyCollection | [optional]  |

### Return type

[**PolicyCollectionResponse**](PolicyCollectionResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Requested PolicyCollection |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listpolicies"></a>
# **ListPolicies**
> List&lt;PolicyResponse&gt; ListPolicies (string? scope = null, DateTimeOffset? asAt = null, List<string>? sortBy = null, int? start = null, int? limit = null, string? filter = null)

[EARLY ACCESS] ListPolicies: List Policies

Gets all Policies in a scope. For pagination support, use PagePolicies.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class ListPoliciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(config);
            var scope = "scope_example";  // string? | Optional. Will use the default scope if not provided. The requested scope (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Optional. The AsAt date time of the data (optional) 
            var sortBy = new List<string>?(); // List<string>? | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var filter = "filter_example";  // string? | Optional. Expression to filter the result set (optional) 

            try
            {
                // [EARLY ACCESS] ListPolicies: List Policies
                List<PolicyResponse> result = apiInstance.ListPolicies(scope, asAt, sortBy, start, limit, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PoliciesApi.ListPolicies: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // [EARLY ACCESS] ListPolicies: List Policies
    ApiResponse<List<PolicyResponse>> response = apiInstance.ListPoliciesWithHttpInfo(scope, asAt, sortBy, start, limit, filter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PoliciesApi.ListPoliciesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string?** | Optional. Will use the default scope if not provided. The requested scope | [optional]  |
| **asAt** | **DateTimeOffset?** | Optional. The AsAt date time of the data | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional]  |
| **start** | **int?** | Optional. When paginating, skip this number of results | [optional]  |
| **limit** | **int?** | Optional. When paginating, limit the number of returned results to this many. | [optional]  |
| **filter** | **string?** | Optional. Expression to filter the result set | [optional]  |

### Return type

[**List&lt;PolicyResponse&gt;**](PolicyResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List Policies |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listpolicycollections"></a>
# **ListPolicyCollections**
> List&lt;PolicyCollectionResponse&gt; ListPolicyCollections (string? scope = null, DateTimeOffset? asAt = null, List<string>? sortBy = null, int? start = null, int? limit = null, string? filter = null)

[EARLY ACCESS] ListPolicyCollections: List PolicyCollections

Gets all PolicyCollections in a scope. For pagination support, use PagePolicyCollections

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class ListPolicyCollectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(config);
            var scope = "scope_example";  // string? | Optional. Will use the default scope if not provided. The requested scope (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Optional. The AsAt date time of the data (optional) 
            var sortBy = new List<string>?(); // List<string>? | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. 2000 if not provided. When paginating, limit the number of returned results to this many. (optional) 
            var filter = "filter_example";  // string? | Optional. Expression to filter the result set (optional) 

            try
            {
                // [EARLY ACCESS] ListPolicyCollections: List PolicyCollections
                List<PolicyCollectionResponse> result = apiInstance.ListPolicyCollections(scope, asAt, sortBy, start, limit, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PoliciesApi.ListPolicyCollections: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // [EARLY ACCESS] ListPolicyCollections: List PolicyCollections
    ApiResponse<List<PolicyCollectionResponse>> response = apiInstance.ListPolicyCollectionsWithHttpInfo(scope, asAt, sortBy, start, limit, filter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PoliciesApi.ListPolicyCollectionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string?** | Optional. Will use the default scope if not provided. The requested scope | [optional]  |
| **asAt** | **DateTimeOffset?** | Optional. The AsAt date time of the data | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional]  |
| **start** | **int?** | Optional. When paginating, skip this number of results | [optional]  |
| **limit** | **int?** | Optional. 2000 if not provided. When paginating, limit the number of returned results to this many. | [optional]  |
| **filter** | **string?** | Optional. Expression to filter the result set | [optional]  |

### Return type

[**List&lt;PolicyCollectionResponse&gt;**](PolicyCollectionResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Requested list of PolicyCollections |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="pagepolicies"></a>
# **PagePolicies**
> ResourceListOfPolicyResponse PagePolicies (DateTimeOffset? asAt = null, string? sortBy = null, int? limit = null, string? filter = null, string? page = null)

[EARLY ACCESS] PagePolicies: Page Policies

Gets all Policies with pagination support.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class PagePoliciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(config);
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Optional. Not currently used. The AsAt date time of the data (optional) 
            var sortBy = "sortBy_example";  // string? | Optional. Order the results by these fields. Use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var limit = 56;  // int? | Optional. 2000 if not provided. When paginating, limit the number of returned results to this many (optional) 
            var filter = "filter_example";  // string? | Optional. Expression to filter the result set (optional) 
            var page = "page_example";  // string? | Optional. Paging token returned from a previous result (optional) 

            try
            {
                // [EARLY ACCESS] PagePolicies: Page Policies
                ResourceListOfPolicyResponse result = apiInstance.PagePolicies(asAt, sortBy, limit, filter, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PoliciesApi.PagePolicies: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // [EARLY ACCESS] PagePolicies: Page Policies
    ApiResponse<ResourceListOfPolicyResponse> response = apiInstance.PagePoliciesWithHttpInfo(asAt, sortBy, limit, filter, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PoliciesApi.PagePoliciesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | Optional. Not currently used. The AsAt date time of the data | [optional]  |
| **sortBy** | **string?** | Optional. Order the results by these fields. Use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional]  |
| **limit** | **int?** | Optional. 2000 if not provided. When paginating, limit the number of returned results to this many | [optional]  |
| **filter** | **string?** | Optional. Expression to filter the result set | [optional]  |
| **page** | **string?** | Optional. Paging token returned from a previous result | [optional]  |

### Return type

[**ResourceListOfPolicyResponse**](ResourceListOfPolicyResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Requested list of Policies |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="pagepolicycollections"></a>
# **PagePolicyCollections**
> ResourceListOfPolicyCollectionResponse PagePolicyCollections (DateTimeOffset? asAt = null, string? sortBy = null, int? limit = null, string? filter = null, string? page = null)

[EARLY ACCESS] PagePolicyCollections: Page PolicyCollections

Gets all PolicyCollections with pagination support.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class PagePolicyCollectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(config);
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Optional. Not currently used. The AsAt date time of the data (optional) 
            var sortBy = "sortBy_example";  // string? | Optional. Order the results by these fields. Use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var limit = 56;  // int? | Optional. 2000 if not provided. When paginating, limit the number of returned results to this many (optional) 
            var filter = "filter_example";  // string? | Optional. Expression to filter the result set (optional) 
            var page = "page_example";  // string? | Optional. Paging token returned from a previous result (optional) 

            try
            {
                // [EARLY ACCESS] PagePolicyCollections: Page PolicyCollections
                ResourceListOfPolicyCollectionResponse result = apiInstance.PagePolicyCollections(asAt, sortBy, limit, filter, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PoliciesApi.PagePolicyCollections: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // [EARLY ACCESS] PagePolicyCollections: Page PolicyCollections
    ApiResponse<ResourceListOfPolicyCollectionResponse> response = apiInstance.PagePolicyCollectionsWithHttpInfo(asAt, sortBy, limit, filter, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PoliciesApi.PagePolicyCollectionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | Optional. Not currently used. The AsAt date time of the data | [optional]  |
| **sortBy** | **string?** | Optional. Order the results by these fields. Use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional]  |
| **limit** | **int?** | Optional. 2000 if not provided. When paginating, limit the number of returned results to this many | [optional]  |
| **filter** | **string?** | Optional. Expression to filter the result set | [optional]  |
| **page** | **string?** | Optional. Paging token returned from a previous result | [optional]  |

### Return type

[**ResourceListOfPolicyCollectionResponse**](ResourceListOfPolicyCollectionResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Requested list of PolicyCollections |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="removefrompolicycollection"></a>
# **RemoveFromPolicyCollection**
> PolicyCollectionResponse RemoveFromPolicyCollection (string code, RemoveFromPolicyCollectionRequest removeFromPolicyCollectionRequest, string? scope = null)

[EARLY ACCESS] RemoveFromPolicyCollection: Remove From PolicyCollection

Remove Policies and/or PolicyCollections from a PolicyCollection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class RemoveFromPolicyCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(config);
            var code = "code_example";  // string | The code of the PolicyCollection
            var removeFromPolicyCollectionRequest = new RemoveFromPolicyCollectionRequest(); // RemoveFromPolicyCollectionRequest | Ids of the PolicyCollections and/or Policies to remove from the PolicyCollection
            var scope = "scope_example";  // string? | Optional. Will use the default scope if not provided. The scope of the PolicyCollection (optional) 

            try
            {
                // [EARLY ACCESS] RemoveFromPolicyCollection: Remove From PolicyCollection
                PolicyCollectionResponse result = apiInstance.RemoveFromPolicyCollection(code, removeFromPolicyCollectionRequest, scope);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PoliciesApi.RemoveFromPolicyCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // [EARLY ACCESS] RemoveFromPolicyCollection: Remove From PolicyCollection
    ApiResponse<PolicyCollectionResponse> response = apiInstance.RemoveFromPolicyCollectionWithHttpInfo(code, removeFromPolicyCollectionRequest, scope);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PoliciesApi.RemoveFromPolicyCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
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

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated PolicyCollection |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatepolicy"></a>
# **UpdatePolicy**
> PolicyResponse UpdatePolicy (string code, PolicyUpdateRequest policyUpdateRequest, string? scope = null)

[EARLY ACCESS] UpdatePolicy: Update Policy

Updates a Policy

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class UpdatePolicyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(config);
            var code = "code_example";  // string | The code of the Policy
            var policyUpdateRequest = new PolicyUpdateRequest(); // PolicyUpdateRequest | The updated definition of the Policy
            var scope = "scope_example";  // string? | Optional. Will use the default scope if not provided. The scope of the Policy (optional) 

            try
            {
                // [EARLY ACCESS] UpdatePolicy: Update Policy
                PolicyResponse result = apiInstance.UpdatePolicy(code, policyUpdateRequest, scope);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PoliciesApi.UpdatePolicy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // [EARLY ACCESS] UpdatePolicy: Update Policy
    ApiResponse<PolicyResponse> response = apiInstance.UpdatePolicyWithHttpInfo(code, policyUpdateRequest, scope);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PoliciesApi.UpdatePolicyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
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

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated policy |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatepolicycollection"></a>
# **UpdatePolicyCollection**
> PolicyCollectionResponse UpdatePolicyCollection (string code, PolicyCollectionUpdateRequest policyCollectionUpdateRequest, string? scope = null)

[EARLY ACCESS] UpdatePolicyCollection: Update PolicyCollection

Updates a PolicyCollection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class UpdatePolicyCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(config);
            var code = "code_example";  // string | The code of the PolicyCollection
            var policyCollectionUpdateRequest = new PolicyCollectionUpdateRequest(); // PolicyCollectionUpdateRequest | The updated definition of the PolicyCollection
            var scope = "scope_example";  // string? | Optional. Will use the default scope if not provided. The scope of the PolicyCollection (optional) 

            try
            {
                // [EARLY ACCESS] UpdatePolicyCollection: Update PolicyCollection
                PolicyCollectionResponse result = apiInstance.UpdatePolicyCollection(code, policyCollectionUpdateRequest, scope);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PoliciesApi.UpdatePolicyCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // [EARLY ACCESS] UpdatePolicyCollection: Update PolicyCollection
    ApiResponse<PolicyCollectionResponse> response = apiInstance.UpdatePolicyCollectionWithHttpInfo(code, policyCollectionUpdateRequest, scope);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PoliciesApi.UpdatePolicyCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
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

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated PolicyCollection |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

