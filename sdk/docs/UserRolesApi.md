# Finbourne.Access.Sdk.Api.UserRolesApi

All URIs are relative to *https://fbn-prd.lusid.com/access*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddPolicyCollectionToUserRole**](UserRolesApi.md#addpolicycollectiontouserrole) | **POST** /api/userroles/{userid}/policycollections | [EXPERIMENTAL] AddPolicyCollectionToUserRole: Add a policy collection to a user-role |
| [**AddPolicyToUserRole**](UserRolesApi.md#addpolicytouserrole) | **POST** /api/userroles/{userid}/policies | [EXPERIMENTAL] AddPolicyToUserRole: Add a policy to a user-role |
| [**CreateUserRole**](UserRolesApi.md#createuserrole) | **POST** /api/userroles | [EXPERIMENTAL] CreateUserRole: Create a user-role |
| [**DeleteUserRole**](UserRolesApi.md#deleteuserrole) | **DELETE** /api/userroles/{userid} | [EXPERIMENTAL] DeleteUserRole: Delete a user-role |
| [**GetUserRole**](UserRolesApi.md#getuserrole) | **GET** /api/userroles/{userid} | [EXPERIMENTAL] GetUserRole: Get a user-role |
| [**ListUserRoles**](UserRolesApi.md#listuserroles) | **GET** /api/userroles | [EXPERIMENTAL] ListUserRoles: List user-roles |
| [**RemovePolicyCollectionFromUserRole**](UserRolesApi.md#removepolicycollectionfromuserrole) | **DELETE** /api/userroles/{userid}/policycollections/{policyCollectionScope}/{policyCollectionCode} | [EXPERIMENTAL] RemovePolicyCollectionFromUserRole: Remove a policy collection from a user-role |
| [**RemovePolicyFromUserRole**](UserRolesApi.md#removepolicyfromuserrole) | **DELETE** /api/userroles/{userid}/policies/{policyScope}/{policyCode} | [EXPERIMENTAL] RemovePolicyFromUserRole: Remove a policy from a user-role |
| [**UpdateUserRole**](UserRolesApi.md#updateuserrole) | **POST** /api/userroles/{userid}/update | [EXPERIMENTAL] UpdateUserRole: Update a user-role |

<a id="addpolicycollectiontouserrole"></a>
# **AddPolicyCollectionToUserRole**
> UserRoleResponse AddPolicyCollectionToUserRole (string userid, AddPolicyCollectionToRoleRequest addPolicyCollectionToRoleRequest)

[EXPERIMENTAL] AddPolicyCollectionToUserRole: Add a policy collection to a user-role

Adds a policy collection to a user-role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class AddPolicyCollectionToUserRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserRolesApi(config);
            var userid = "userid_example";  // string | Id of the User Role to get
            var addPolicyCollectionToRoleRequest = new AddPolicyCollectionToRoleRequest(); // AddPolicyCollectionToRoleRequest | Dto of the policy collection to be added.

            try
            {
                // [EXPERIMENTAL] AddPolicyCollectionToUserRole: Add a policy collection to a user-role
                UserRoleResponse result = apiInstance.AddPolicyCollectionToUserRole(userid, addPolicyCollectionToRoleRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserRolesApi.AddPolicyCollectionToUserRole: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddPolicyCollectionToUserRoleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] AddPolicyCollectionToUserRole: Add a policy collection to a user-role
    ApiResponse<UserRoleResponse> response = apiInstance.AddPolicyCollectionToUserRoleWithHttpInfo(userid, addPolicyCollectionToRoleRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserRolesApi.AddPolicyCollectionToUserRoleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userid** | **string** | Id of the User Role to get |  |
| **addPolicyCollectionToRoleRequest** | [**AddPolicyCollectionToRoleRequest**](AddPolicyCollectionToRoleRequest.md) | Dto of the policy collection to be added. |  |

### Return type

[**UserRoleResponse**](UserRoleResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User role with added policy collection. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addpolicytouserrole"></a>
# **AddPolicyToUserRole**
> UserRoleResponse AddPolicyToUserRole (string userid, AddPolicyToRoleRequest addPolicyToRoleRequest)

[EXPERIMENTAL] AddPolicyToUserRole: Add a policy to a user-role

Adds a policy to a user-role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class AddPolicyToUserRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserRolesApi(config);
            var userid = "userid_example";  // string | Id of the User Role to get
            var addPolicyToRoleRequest = new AddPolicyToRoleRequest(); // AddPolicyToRoleRequest | Dto of the policy to be added.

            try
            {
                // [EXPERIMENTAL] AddPolicyToUserRole: Add a policy to a user-role
                UserRoleResponse result = apiInstance.AddPolicyToUserRole(userid, addPolicyToRoleRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserRolesApi.AddPolicyToUserRole: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddPolicyToUserRoleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] AddPolicyToUserRole: Add a policy to a user-role
    ApiResponse<UserRoleResponse> response = apiInstance.AddPolicyToUserRoleWithHttpInfo(userid, addPolicyToRoleRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserRolesApi.AddPolicyToUserRoleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userid** | **string** | Id of the User Role to get |  |
| **addPolicyToRoleRequest** | [**AddPolicyToRoleRequest**](AddPolicyToRoleRequest.md) | Dto of the policy to be added. |  |

### Return type

[**UserRoleResponse**](UserRoleResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User role with added policy collection. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createuserrole"></a>
# **CreateUserRole**
> UserRoleResponse CreateUserRole (UserRoleCreationRequest userRoleCreationRequest)

[EXPERIMENTAL] CreateUserRole: Create a user-role

Creates a new user-role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class CreateUserRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserRolesApi(config);
            var userRoleCreationRequest = new UserRoleCreationRequest(); // UserRoleCreationRequest | Definition of the user-role to create.

            try
            {
                // [EXPERIMENTAL] CreateUserRole: Create a user-role
                UserRoleResponse result = apiInstance.CreateUserRole(userRoleCreationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserRolesApi.CreateUserRole: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateUserRoleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateUserRole: Create a user-role
    ApiResponse<UserRoleResponse> response = apiInstance.CreateUserRoleWithHttpInfo(userRoleCreationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserRolesApi.CreateUserRoleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userRoleCreationRequest** | [**UserRoleCreationRequest**](UserRoleCreationRequest.md) | Definition of the user-role to create. |  |

### Return type

[**UserRoleResponse**](UserRoleResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User role that has been created. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteuserrole"></a>
# **DeleteUserRole**
> void DeleteUserRole (string userid)

[EXPERIMENTAL] DeleteUserRole: Delete a user-role

Deletes an identified user-role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class DeleteUserRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserRolesApi(config);
            var userid = "userid_example";  // string | Id of the user-role to delete.

            try
            {
                // [EXPERIMENTAL] DeleteUserRole: Delete a user-role
                apiInstance.DeleteUserRole(userid);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserRolesApi.DeleteUserRole: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteUserRoleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteUserRole: Delete a user-role
    apiInstance.DeleteUserRoleWithHttpInfo(userid);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserRolesApi.DeleteUserRoleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userid** | **string** | Id of the user-role to delete. |  |

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

<a id="getuserrole"></a>
# **GetUserRole**
> UserRoleResponse GetUserRole (string userid)

[EXPERIMENTAL] GetUserRole: Get a user-role

Get an identified user-role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class GetUserRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserRolesApi(config);
            var userid = "userid_example";  // string | Id of the user-role to get.

            try
            {
                // [EXPERIMENTAL] GetUserRole: Get a user-role
                UserRoleResponse result = apiInstance.GetUserRole(userid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserRolesApi.GetUserRole: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserRoleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetUserRole: Get a user-role
    ApiResponse<UserRoleResponse> response = apiInstance.GetUserRoleWithHttpInfo(userid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserRolesApi.GetUserRoleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userid** | **string** | Id of the user-role to get. |  |

### Return type

[**UserRoleResponse**](UserRoleResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested user role. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listuserroles"></a>
# **ListUserRoles**
> ResourceListOfUserRoleResponse ListUserRoles (string? filter = null, string? sortBy = null, int? limit = null, string? page = null)

[EXPERIMENTAL] ListUserRoles: List user-roles

Lists all user-roles and pages.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class ListUserRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserRolesApi(config);
            var filter = "filter_example";  // string? | Optional. Expression to filter the result set (optional) 
            var sortBy = "sortBy_example";  // string? | Optional. Order the results by these fields. Use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var page = "page_example";  // string? | Optional. Encoded page string returned from a previous search result that will retrieve              the next page of data. (optional) 

            try
            {
                // [EXPERIMENTAL] ListUserRoles: List user-roles
                ResourceListOfUserRoleResponse result = apiInstance.ListUserRoles(filter, sortBy, limit, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserRolesApi.ListUserRoles: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListUserRolesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListUserRoles: List user-roles
    ApiResponse<ResourceListOfUserRoleResponse> response = apiInstance.ListUserRolesWithHttpInfo(filter, sortBy, limit, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserRolesApi.ListUserRolesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filter** | **string?** | Optional. Expression to filter the result set | [optional]  |
| **sortBy** | **string?** | Optional. Order the results by these fields. Use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional]  |
| **limit** | **int?** | Optional. When paginating, limit the number of returned results to this many. | [optional]  |
| **page** | **string?** | Optional. Encoded page string returned from a previous search result that will retrieve              the next page of data. | [optional]  |

### Return type

[**ResourceListOfUserRoleResponse**](ResourceListOfUserRoleResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="removepolicycollectionfromuserrole"></a>
# **RemovePolicyCollectionFromUserRole**
> void RemovePolicyCollectionFromUserRole (string userid, string policyCollectionScope, string policyCollectionCode)

[EXPERIMENTAL] RemovePolicyCollectionFromUserRole: Remove a policy collection from a user-role

Removes a policy collection from a user-role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class RemovePolicyCollectionFromUserRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserRolesApi(config);
            var userid = "userid_example";  // string | Id of the User Role to get
            var policyCollectionScope = "policyCollectionScope_example";  // string | The scope of policy collection to remove from the User Role
            var policyCollectionCode = "policyCollectionCode_example";  // string | The code of the policy collection to remove from the User Role

            try
            {
                // [EXPERIMENTAL] RemovePolicyCollectionFromUserRole: Remove a policy collection from a user-role
                apiInstance.RemovePolicyCollectionFromUserRole(userid, policyCollectionScope, policyCollectionCode);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserRolesApi.RemovePolicyCollectionFromUserRole: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemovePolicyCollectionFromUserRoleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] RemovePolicyCollectionFromUserRole: Remove a policy collection from a user-role
    apiInstance.RemovePolicyCollectionFromUserRoleWithHttpInfo(userid, policyCollectionScope, policyCollectionCode);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserRolesApi.RemovePolicyCollectionFromUserRoleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userid** | **string** | Id of the User Role to get |  |
| **policyCollectionScope** | **string** | The scope of policy collection to remove from the User Role |  |
| **policyCollectionCode** | **string** | The code of the policy collection to remove from the User Role |  |

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

<a id="removepolicyfromuserrole"></a>
# **RemovePolicyFromUserRole**
> void RemovePolicyFromUserRole (string userid, string policyScope, string policyCode)

[EXPERIMENTAL] RemovePolicyFromUserRole: Remove a policy from a user-role

Removes a policy from a user-role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class RemovePolicyFromUserRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserRolesApi(config);
            var userid = "userid_example";  // string | Id of the User Role to get
            var policyScope = "policyScope_example";  // string | The scope of the policy to remove from the User Role
            var policyCode = "policyCode_example";  // string | The code of the policy to remove from the User Role

            try
            {
                // [EXPERIMENTAL] RemovePolicyFromUserRole: Remove a policy from a user-role
                apiInstance.RemovePolicyFromUserRole(userid, policyScope, policyCode);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserRolesApi.RemovePolicyFromUserRole: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemovePolicyFromUserRoleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] RemovePolicyFromUserRole: Remove a policy from a user-role
    apiInstance.RemovePolicyFromUserRoleWithHttpInfo(userid, policyScope, policyCode);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserRolesApi.RemovePolicyFromUserRoleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userid** | **string** | Id of the User Role to get |  |
| **policyScope** | **string** | The scope of the policy to remove from the User Role |  |
| **policyCode** | **string** | The code of the policy to remove from the User Role |  |

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

<a id="updateuserrole"></a>
# **UpdateUserRole**
> UserRoleResponse UpdateUserRole (string userid, UserRoleUpdateRequest userRoleUpdateRequest)

[EXPERIMENTAL] UpdateUserRole: Update a user-role

Updates an identified user-role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class UpdateUserRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserRolesApi(config);
            var userid = "userid_example";  // string | Id of the user-role to be updated.
            var userRoleUpdateRequest = new UserRoleUpdateRequest(); // UserRoleUpdateRequest | Definition of the update to apply to the user-role.

            try
            {
                // [EXPERIMENTAL] UpdateUserRole: Update a user-role
                UserRoleResponse result = apiInstance.UpdateUserRole(userid, userRoleUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserRolesApi.UpdateUserRole: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateUserRoleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpdateUserRole: Update a user-role
    ApiResponse<UserRoleResponse> response = apiInstance.UpdateUserRoleWithHttpInfo(userid, userRoleUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserRolesApi.UpdateUserRoleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userid** | **string** | Id of the user-role to be updated. |  |
| **userRoleUpdateRequest** | [**UserRoleUpdateRequest**](UserRoleUpdateRequest.md) | Definition of the update to apply to the user-role. |  |

### Return type

[**UserRoleResponse**](UserRoleResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User role that has been updated. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

