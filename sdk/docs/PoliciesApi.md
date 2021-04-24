# Finbourne.Access.Sdk.Api.PoliciesApi

All URIs are relative to *https://www.lusid.com/access*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePolicy**](PoliciesApi.md#createpolicy) | **POST** /api/policies | [EARLY ACCESS] Create Policy
[**CreatePolicyCollection**](PoliciesApi.md#createpolicycollection) | **POST** /api/policycollections | [EARLY ACCESS] Create PolicyCollection
[**DeletePolicy**](PoliciesApi.md#deletepolicy) | **DELETE** /api/policies/{code} | [EARLY ACCESS] Delete Policy
[**DeletePolicyCollection**](PoliciesApi.md#deletepolicycollection) | **DELETE** /api/policycollections/{code} | [EARLY ACCESS] Delete PolicyCollection
[**Evaluate**](PoliciesApi.md#evaluate) | **POST** /api/me | [EARLY ACCESS] Run one or more evaluations
[**GetOwnPolicies**](PoliciesApi.md#getownpolicies) | **GET** /api/me | Get policies of requesting user
[**GetPolicy**](PoliciesApi.md#getpolicy) | **GET** /api/policies/{code} | [EARLY ACCESS] Get Policy
[**GetPolicyCollection**](PoliciesApi.md#getpolicycollection) | **GET** /api/policycollections/{code} | [EARLY ACCESS] Get PolicyCollection
[**ListPolicies**](PoliciesApi.md#listpolicies) | **GET** /api/policies | [EARLY ACCESS] List Policies
[**ListPolicyCollections**](PoliciesApi.md#listpolicycollections) | **GET** /api/policycollections | [EARLY ACCESS] List PolicyCollections
[**UpdatePolicy**](PoliciesApi.md#updatepolicy) | **PUT** /api/policies/{code} | [EARLY ACCESS] Update Policy
[**UpdatePolicyCollection**](PoliciesApi.md#updatepolicycollection) | **PUT** /api/policycollections/{code} | [EARLY ACCESS] Update PolicyCollection



## CreatePolicy

> PolicyResponse CreatePolicy (PolicyCreationRequest policyCreationRequest)

[EARLY ACCESS] Create Policy

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
            Configuration.Default.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(Configuration.Default);
            var policyCreationRequest = new PolicyCreationRequest(); // PolicyCreationRequest | The definition of the Policy

            try
            {
                // [EARLY ACCESS] Create Policy
                PolicyResponse result = apiInstance.CreatePolicy(policyCreationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PoliciesApi.CreatePolicy: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **policyCreationRequest** | [**PolicyCreationRequest**](PolicyCreationRequest.md)| The definition of the Policy | 

### Return type

[**PolicyResponse**](PolicyResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created policy |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreatePolicyCollection

> PolicyCollectionResponse CreatePolicyCollection (PolicyCollectionCreationRequest policyCollectionCreationRequest)

[EARLY ACCESS] Create PolicyCollection

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
            Configuration.Default.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(Configuration.Default);
            var policyCollectionCreationRequest = new PolicyCollectionCreationRequest(); // PolicyCollectionCreationRequest | The definition of the PolicyCollection

            try
            {
                // [EARLY ACCESS] Create PolicyCollection
                PolicyCollectionResponse result = apiInstance.CreatePolicyCollection(policyCollectionCreationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PoliciesApi.CreatePolicyCollection: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **policyCollectionCreationRequest** | [**PolicyCollectionCreationRequest**](PolicyCollectionCreationRequest.md)| The definition of the PolicyCollection | 

### Return type

[**PolicyCollectionResponse**](PolicyCollectionResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created PolicyCollection |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeletePolicy

> void DeletePolicy (string code, string scope = null)

[EARLY ACCESS] Delete Policy

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
            Configuration.Default.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(Configuration.Default);
            var code = code_example;  // string | The code of the Policy
            var scope = scope_example;  // string | Optional. Will use the default scope if not provided. The scope of the Policy (optional) 

            try
            {
                // [EARLY ACCESS] Delete Policy
                apiInstance.DeletePolicy(code, scope);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PoliciesApi.DeletePolicy: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **string**| The code of the Policy | 
 **scope** | **string**| Optional. Will use the default scope if not provided. The scope of the Policy | [optional] 

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
| **204** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeletePolicyCollection

> void DeletePolicyCollection (string code, string scope = null)

[EARLY ACCESS] Delete PolicyCollection

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
            Configuration.Default.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(Configuration.Default);
            var code = code_example;  // string | The code of the PolicyCollection
            var scope = scope_example;  // string | Optional. Will use the default scope if not provided. The scope of the PolicyCollection (optional) 

            try
            {
                // [EARLY ACCESS] Delete PolicyCollection
                apiInstance.DeletePolicyCollection(code, scope);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PoliciesApi.DeletePolicyCollection: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **string**| The code of the PolicyCollection | 
 **scope** | **string**| Optional. Will use the default scope if not provided. The scope of the PolicyCollection | [optional] 

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
| **204** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Evaluate

> Dictionary&lt;string, EvaluationResponse&gt; Evaluate (Dictionary<string, EvaluationRequest> requestBody, List<string> applications = null, DateTimeOffset? asAt = null)

[EARLY ACCESS] Run one or more evaluations

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
            Configuration.Default.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(Configuration.Default);
            var requestBody = new Dictionary<string, EvaluationRequest>(); // Dictionary<string, EvaluationRequest> | A dictionary of evaluations, keyed using any arbitrary correlation id (it will be returned with the response for that evaluation).
            var applications = new List<string>(); // List<string> | Optional. The application type of the roles and policies to use when evaluating. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The requested AsAt date of the entitlements (optional) 

            try
            {
                // [EARLY ACCESS] Run one or more evaluations
                Dictionary<string, EvaluationResponse> result = apiInstance.Evaluate(requestBody, applications, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PoliciesApi.Evaluate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestBody** | [**Dictionary&lt;string, EvaluationRequest&gt;**](EvaluationRequest.md)| A dictionary of evaluations, keyed using any arbitrary correlation id (it will be returned with the response for that evaluation). | 
 **applications** | [**List&lt;string&gt;**](string.md)| Optional. The application type of the roles and policies to use when evaluating. | [optional] 
 **asAt** | **DateTimeOffset?**| Optional. The requested AsAt date of the entitlements | [optional] 

### Return type

[**Dictionary&lt;string, EvaluationResponse&gt;**](EvaluationResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Run an evaluation against the current user&#39;s entitlements |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetOwnPolicies

> ICollection&lt;AttachedPolicyDefinitionResponse&gt; GetOwnPolicies (List<string> applications = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null)

Get policies of requesting user

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
            Configuration.Default.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(Configuration.Default);
            var applications = new List<string>(); // List<string> | Optional. Filter on the applications that the policies apply to (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date time of the data (optional) 
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set (optional) 

            try
            {
                // Get policies of requesting user
                ICollection<AttachedPolicyDefinitionResponse> result = apiInstance.GetOwnPolicies(applications, asAt, sortBy, start, limit, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PoliciesApi.GetOwnPolicies: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applications** | [**List&lt;string&gt;**](string.md)| Optional. Filter on the applications that the policies apply to | [optional] 
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date time of the data | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many. | [optional] 
 **filter** | **string**| Optional. Expression to filter the result set | [optional] 

### Return type

[**ICollection&lt;AttachedPolicyDefinitionResponse&gt;**](AttachedPolicyDefinitionResponse.md)

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPolicy

> PolicyResponse GetPolicy (string code, DateTimeOffset? asAt = null, string scope = null)

[EARLY ACCESS] Get Policy

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
            Configuration.Default.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(Configuration.Default);
            var code = code_example;  // string | The code of the Policy
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date time of the data (optional) 
            var scope = scope_example;  // string | Optional. Will use the default scope if not provided. The scope of the Policy (optional) 

            try
            {
                // [EARLY ACCESS] Get Policy
                PolicyResponse result = apiInstance.GetPolicy(code, asAt, scope);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PoliciesApi.GetPolicy: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **string**| The code of the Policy | 
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date time of the data | [optional] 
 **scope** | **string**| Optional. Will use the default scope if not provided. The scope of the Policy | [optional] 

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPolicyCollection

> PolicyCollectionResponse GetPolicyCollection (string code, DateTimeOffset? asAt = null, string scope = null)

[EARLY ACCESS] Get PolicyCollection

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
            Configuration.Default.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(Configuration.Default);
            var code = code_example;  // string | The code of the PolicyCollection
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date time of the data (optional) 
            var scope = scope_example;  // string | Optional. Will use the default scope if not provided. The scope of the PolicyCollection (optional) 

            try
            {
                // [EARLY ACCESS] Get PolicyCollection
                PolicyCollectionResponse result = apiInstance.GetPolicyCollection(code, asAt, scope);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PoliciesApi.GetPolicyCollection: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **string**| The code of the PolicyCollection | 
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date time of the data | [optional] 
 **scope** | **string**| Optional. Will use the default scope if not provided. The scope of the PolicyCollection | [optional] 

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListPolicies

> ICollection&lt;PolicyResponse&gt; ListPolicies (string scope = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null)

[EARLY ACCESS] List Policies

Gets all Policies in a scope

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
            Configuration.Default.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(Configuration.Default);
            var scope = scope_example;  // string | Optional. Will use the default scope if not provided. The requested scope (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date time of the data (optional) 
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set (optional) 

            try
            {
                // [EARLY ACCESS] List Policies
                ICollection<PolicyResponse> result = apiInstance.ListPolicies(scope, asAt, sortBy, start, limit, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PoliciesApi.ListPolicies: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| Optional. Will use the default scope if not provided. The requested scope | [optional] 
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date time of the data | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many. | [optional] 
 **filter** | **string**| Optional. Expression to filter the result set | [optional] 

### Return type

[**ICollection&lt;PolicyResponse&gt;**](PolicyResponse.md)

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListPolicyCollections

> ICollection&lt;PolicyCollectionResponse&gt; ListPolicyCollections (string scope = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null)

[EARLY ACCESS] List PolicyCollections

Gets all PolicyCollections in a scope

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
            Configuration.Default.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(Configuration.Default);
            var scope = scope_example;  // string | Optional. Will use the default scope if not provided. The requested scope (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date time of the data (optional) 
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set (optional) 

            try
            {
                // [EARLY ACCESS] List PolicyCollections
                ICollection<PolicyCollectionResponse> result = apiInstance.ListPolicyCollections(scope, asAt, sortBy, start, limit, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PoliciesApi.ListPolicyCollections: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| Optional. Will use the default scope if not provided. The requested scope | [optional] 
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date time of the data | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many. | [optional] 
 **filter** | **string**| Optional. Expression to filter the result set | [optional] 

### Return type

[**ICollection&lt;PolicyCollectionResponse&gt;**](PolicyCollectionResponse.md)

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdatePolicy

> PolicyResponse UpdatePolicy (string code, PolicyUpdateRequest policyUpdateRequest, string scope = null)

[EARLY ACCESS] Update Policy

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
            Configuration.Default.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(Configuration.Default);
            var code = code_example;  // string | The code of the Policy
            var policyUpdateRequest = new PolicyUpdateRequest(); // PolicyUpdateRequest | The updated definition of the Policy
            var scope = scope_example;  // string | Optional. Will use the default scope if not provided. The scope of the Policy (optional) 

            try
            {
                // [EARLY ACCESS] Update Policy
                PolicyResponse result = apiInstance.UpdatePolicy(code, policyUpdateRequest, scope);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PoliciesApi.UpdatePolicy: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **string**| The code of the Policy | 
 **policyUpdateRequest** | [**PolicyUpdateRequest**](PolicyUpdateRequest.md)| The updated definition of the Policy | 
 **scope** | **string**| Optional. Will use the default scope if not provided. The scope of the Policy | [optional] 

### Return type

[**PolicyResponse**](PolicyResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated policy |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdatePolicyCollection

> PolicyCollectionResponse UpdatePolicyCollection (string code, PolicyCollectionUpdateRequest policyCollectionUpdateRequest, string scope = null)

[EARLY ACCESS] Update PolicyCollection

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
            Configuration.Default.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesApi(Configuration.Default);
            var code = code_example;  // string | The code of the PolicyCollection
            var policyCollectionUpdateRequest = new PolicyCollectionUpdateRequest(); // PolicyCollectionUpdateRequest | The updated definition of the PolicyCollection
            var scope = scope_example;  // string | Optional. Will use the default scope if not provided. The scope of the PolicyCollection (optional) 

            try
            {
                // [EARLY ACCESS] Update PolicyCollection
                PolicyCollectionResponse result = apiInstance.UpdatePolicyCollection(code, policyCollectionUpdateRequest, scope);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PoliciesApi.UpdatePolicyCollection: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **string**| The code of the PolicyCollection | 
 **policyCollectionUpdateRequest** | [**PolicyCollectionUpdateRequest**](PolicyCollectionUpdateRequest.md)| The updated definition of the PolicyCollection | 
 **scope** | **string**| Optional. Will use the default scope if not provided. The scope of the PolicyCollection | [optional] 

### Return type

[**PolicyCollectionResponse**](PolicyCollectionResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated PolicyCollection |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

