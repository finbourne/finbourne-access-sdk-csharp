# Finbourne.Access.Sdk.Api.RolesApi

All URIs are relative to *https://www.lusid.com/access*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddPolicyCollectionToRole**](RolesApi.md#addpolicycollectiontorole) | **POST** /api/roles/{scope}/{code}/policycollections | [EXPERIMENTAL] Add policy collections to a role
[**CreateRole**](RolesApi.md#createrole) | **POST** /api/roles | [EARLY ACCESS] Create Role
[**DeleteRole**](RolesApi.md#deleterole) | **DELETE** /api/roles/{code} | [EARLY ACCESS] Delete Role
[**GetRole**](RolesApi.md#getrole) | **GET** /api/roles/{code} | [EARLY ACCESS] Get Role
[**ListRoles**](RolesApi.md#listroles) | **GET** /api/roles | [EARLY ACCESS] List Roles
[**RemovePolicyCollectionFromRole**](RolesApi.md#removepolicycollectionfromrole) | **DELETE** /api/roles/{scope}/{code}/policycollections/{policycollectionscope}/{policycollectioncode} | [EXPERIMENTAL] Remove policy collection from role
[**UpdateRole**](RolesApi.md#updaterole) | **PUT** /api/roles/{code} | [EARLY ACCESS] Update Role



## AddPolicyCollectionToRole

> RoleResponse AddPolicyCollectionToRole (string scope, string code, AddPolicyCollectionToRoleRequest addPolicyCollectionToRoleRequest)

[EXPERIMENTAL] Add policy collections to a role

Assigns policy collections to a role

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class AddPolicyCollectionToRoleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RolesApi(Configuration.Default);
            var scope = scope_example;  // string | The scope of the Role
            var code = code_example;  // string | The code of the Role
            var addPolicyCollectionToRoleRequest = new AddPolicyCollectionToRoleRequest(); // AddPolicyCollectionToRoleRequest | The policy collections to add

            try
            {
                // [EXPERIMENTAL] Add policy collections to a role
                RoleResponse result = apiInstance.AddPolicyCollectionToRole(scope, code, addPolicyCollectionToRoleRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RolesApi.AddPolicyCollectionToRole: " + e.Message );
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
 **scope** | **string**| The scope of the Role | 
 **code** | **string**| The code of the Role | 
 **addPolicyCollectionToRoleRequest** | [**AddPolicyCollectionToRoleRequest**](AddPolicyCollectionToRoleRequest.md)| The policy collections to add | 

### Return type

[**RoleResponse**](RoleResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | AddPolicyCollectionToRole |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateRole

> RoleResponse CreateRole (RoleCreationRequest roleCreationRequest)

[EARLY ACCESS] Create Role

Creates a Role

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class CreateRoleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RolesApi(Configuration.Default);
            var roleCreationRequest = new RoleCreationRequest(); // RoleCreationRequest | The definition of the Role

            try
            {
                // [EARLY ACCESS] Create Role
                RoleResponse result = apiInstance.CreateRole(roleCreationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RolesApi.CreateRole: " + e.Message );
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
 **roleCreationRequest** | [**RoleCreationRequest**](RoleCreationRequest.md)| The definition of the Role | 

### Return type

[**RoleResponse**](RoleResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created Role |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteRole

> void DeleteRole (string code, string scope = null)

[EARLY ACCESS] Delete Role

Deletes an identified Role

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class DeleteRoleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RolesApi(Configuration.Default);
            var code = code_example;  // string | The code of the Role
            var scope = scope_example;  // string | >Optional. Will use default scope if not supplied. The scope of the Role (optional) 

            try
            {
                // [EARLY ACCESS] Delete Role
                apiInstance.DeleteRole(code, scope);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RolesApi.DeleteRole: " + e.Message );
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
 **code** | **string**| The code of the Role | 
 **scope** | **string**| &gt;Optional. Will use default scope if not supplied. The scope of the Role | [optional] 

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


## GetRole

> RoleResponse GetRole (string code, DateTimeOffset? asAt = null, string scope = null)

[EARLY ACCESS] Get Role

Gets an identified Role

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class GetRoleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RolesApi(Configuration.Default);
            var code = code_example;  // string | The code of the Role
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date time of the data (optional) 
            var scope = scope_example;  // string | Optional. Will use default scope if not supplied. The scope of the Role (optional) 

            try
            {
                // [EARLY ACCESS] Get Role
                RoleResponse result = apiInstance.GetRole(code, asAt, scope);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RolesApi.GetRole: " + e.Message );
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
 **code** | **string**| The code of the Role | 
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date time of the data | [optional] 
 **scope** | **string**| Optional. Will use default scope if not supplied. The scope of the Role | [optional] 

### Return type

[**RoleResponse**](RoleResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Requested Role |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListRoles

> ICollection&lt;RoleResponse&gt; ListRoles (string scope = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null)

[EARLY ACCESS] List Roles

Gets all Roles in a scope

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class ListRolesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RolesApi(Configuration.Default);
            var scope = scope_example;  // string | Optional. Will use all scopes if not supplied. The requested scope (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date time of the data (optional) 
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set (optional) 

            try
            {
                // [EARLY ACCESS] List Roles
                ICollection<RoleResponse> result = apiInstance.ListRoles(scope, asAt, sortBy, start, limit, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RolesApi.ListRoles: " + e.Message );
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
 **scope** | **string**| Optional. Will use all scopes if not supplied. The requested scope | [optional] 
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date time of the data | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many. | [optional] 
 **filter** | **string**| Optional. Expression to filter the result set | [optional] 

### Return type

[**ICollection&lt;RoleResponse&gt;**](RoleResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of Roles |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RemovePolicyCollectionFromRole

> RoleResponse RemovePolicyCollectionFromRole (string scope, string code, string policycollectionscope, string policycollectioncode)

[EXPERIMENTAL] Remove policy collection from role

Removes a policy collection from a role

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class RemovePolicyCollectionFromRoleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RolesApi(Configuration.Default);
            var scope = scope_example;  // string | The scope of the Role
            var code = code_example;  // string | The code of the Role
            var policycollectionscope = policycollectionscope_example;  // string | The scope of policy collection to remove from the Role
            var policycollectioncode = policycollectioncode_example;  // string | The code of the policy collection to remove from the Role

            try
            {
                // [EXPERIMENTAL] Remove policy collection from role
                RoleResponse result = apiInstance.RemovePolicyCollectionFromRole(scope, code, policycollectionscope, policycollectioncode);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RolesApi.RemovePolicyCollectionFromRole: " + e.Message );
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
 **scope** | **string**| The scope of the Role | 
 **code** | **string**| The code of the Role | 
 **policycollectionscope** | **string**| The scope of policy collection to remove from the Role | 
 **policycollectioncode** | **string**| The code of the policy collection to remove from the Role | 

### Return type

[**RoleResponse**](RoleResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | RemovePolicyCollectionFromRole |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateRole

> RoleResponse UpdateRole (string code, RoleUpdateRequest roleUpdateRequest, string scope = null, string beforeScope = null, string beforeCode = null, string afterScope = null, string afterCode = null)

[EARLY ACCESS] Update Role

Updates a Role

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class UpdateRoleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RolesApi(Configuration.Default);
            var code = code_example;  // string | The code of the Role
            var roleUpdateRequest = new RoleUpdateRequest(); // RoleUpdateRequest | The updated definition of the Role
            var scope = scope_example;  // string | >Optional. Will use default scope if not supplied. The scope of the Role (optional) 
            var beforeScope = beforeScope_example;  // string | Optional. The scope of the Role. Will use default scope if not supplied. (optional) 
            var beforeCode = beforeCode_example;  // string | Optional. The code of the Role (optional) 
            var afterScope = afterScope_example;  // string | Optional. The scope of the Role. Will use default scope if not supplied. (optional) 
            var afterCode = afterCode_example;  // string | Optional. The code of the Role (optional) 

            try
            {
                // [EARLY ACCESS] Update Role
                RoleResponse result = apiInstance.UpdateRole(code, roleUpdateRequest, scope, beforeScope, beforeCode, afterScope, afterCode);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RolesApi.UpdateRole: " + e.Message );
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
 **code** | **string**| The code of the Role | 
 **roleUpdateRequest** | [**RoleUpdateRequest**](RoleUpdateRequest.md)| The updated definition of the Role | 
 **scope** | **string**| &gt;Optional. Will use default scope if not supplied. The scope of the Role | [optional] 
 **beforeScope** | **string**| Optional. The scope of the Role. Will use default scope if not supplied. | [optional] 
 **beforeCode** | **string**| Optional. The code of the Role | [optional] 
 **afterScope** | **string**| Optional. The scope of the Role. Will use default scope if not supplied. | [optional] 
 **afterCode** | **string**| Optional. The code of the Role | [optional] 

### Return type

[**RoleResponse**](RoleResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated Role |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

