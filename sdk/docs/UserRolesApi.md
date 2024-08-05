# Finbourne.Access.Sdk.Api.UserRolesApi

All URIs are relative to *https://fbn-prd.lusid.com/access*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddPolicyCollectionToUserRole**](UserRolesApi.md#addpolicycollectiontouserrole) | **POST** /api/userroles/{userid}/policycollections | AddPolicyCollectionToUserRole: Add a policy collection to a user-role |
| [**AddPolicyToUserRole**](UserRolesApi.md#addpolicytouserrole) | **POST** /api/userroles/{userid}/policies | AddPolicyToUserRole: Add a policy to a user-role |
| [**CreateUserRole**](UserRolesApi.md#createuserrole) | **POST** /api/userroles | CreateUserRole: Create a user-role |
| [**DeleteUserRole**](UserRolesApi.md#deleteuserrole) | **DELETE** /api/userroles/{userid} | DeleteUserRole: Delete a user-role |
| [**GetUserRole**](UserRolesApi.md#getuserrole) | **GET** /api/userroles/{userid} | GetUserRole: Get a user-role |
| [**ListUserRoles**](UserRolesApi.md#listuserroles) | **GET** /api/userroles | ListUserRoles: List user-roles |
| [**RemovePolicyCollectionFromUserRole**](UserRolesApi.md#removepolicycollectionfromuserrole) | **DELETE** /api/userroles/{userid}/policycollections/{policyCollectionScope}/{policyCollectionCode} | RemovePolicyCollectionFromUserRole: Remove a policy collection from a user-role |
| [**RemovePolicyFromUserRole**](UserRolesApi.md#removepolicyfromuserrole) | **DELETE** /api/userroles/{userid}/policies/{policyScope}/{policyCode} | RemovePolicyFromUserRole: Remove a policy from a user-role |
| [**UpdateUserRole**](UserRolesApi.md#updateuserrole) | **POST** /api/userroles/{userid}/update | UpdateUserRole: Update a user-role |

<a id="addpolicycollectiontouserrole"></a>
# **AddPolicyCollectionToUserRole**
> UserRoleResponse AddPolicyCollectionToUserRole (string userid, AddPolicyCollectionToRoleRequest addPolicyCollectionToRoleRequest)

AddPolicyCollectionToUserRole: Add a policy collection to a user-role

Adds a policy collection to a user-role.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<UserRolesApi>();
            var userid = "userid_example";  // string | Id of the User Role to get
            var addPolicyCollectionToRoleRequest = new AddPolicyCollectionToRoleRequest(); // AddPolicyCollectionToRoleRequest | Dto of the policy collection to be added.

            try
            {
                // AddPolicyCollectionToUserRole: Add a policy collection to a user-role
                UserRoleResponse result = apiInstance.AddPolicyCollectionToUserRole(userid, addPolicyCollectionToRoleRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling UserRolesApi.AddPolicyCollectionToUserRole: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    // AddPolicyCollectionToUserRole: Add a policy collection to a user-role
    ApiResponse<UserRoleResponse> response = apiInstance.AddPolicyCollectionToUserRoleWithHttpInfo(userid, addPolicyCollectionToRoleRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling UserRolesApi.AddPolicyCollectionToUserRoleWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userid** | **string** | Id of the User Role to get |  |
| **addPolicyCollectionToRoleRequest** | [**AddPolicyCollectionToRoleRequest**](AddPolicyCollectionToRoleRequest.md) | Dto of the policy collection to be added. |  |

### Return type

[**UserRoleResponse**](UserRoleResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User role with added policy collection. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="addpolicytouserrole"></a>
# **AddPolicyToUserRole**
> UserRoleResponse AddPolicyToUserRole (string userid, AddPolicyToRoleRequest addPolicyToRoleRequest)

AddPolicyToUserRole: Add a policy to a user-role

Adds a policy to a user-role.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<UserRolesApi>();
            var userid = "userid_example";  // string | Id of the User Role to get
            var addPolicyToRoleRequest = new AddPolicyToRoleRequest(); // AddPolicyToRoleRequest | Dto of the policy to be added.

            try
            {
                // AddPolicyToUserRole: Add a policy to a user-role
                UserRoleResponse result = apiInstance.AddPolicyToUserRole(userid, addPolicyToRoleRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling UserRolesApi.AddPolicyToUserRole: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    // AddPolicyToUserRole: Add a policy to a user-role
    ApiResponse<UserRoleResponse> response = apiInstance.AddPolicyToUserRoleWithHttpInfo(userid, addPolicyToRoleRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling UserRolesApi.AddPolicyToUserRoleWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userid** | **string** | Id of the User Role to get |  |
| **addPolicyToRoleRequest** | [**AddPolicyToRoleRequest**](AddPolicyToRoleRequest.md) | Dto of the policy to be added. |  |

### Return type

[**UserRoleResponse**](UserRoleResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User role with added policy collection. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="createuserrole"></a>
# **CreateUserRole**
> UserRoleResponse CreateUserRole (UserRoleCreationRequest userRoleCreationRequest)

CreateUserRole: Create a user-role

Creates a new user-role.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<UserRolesApi>();
            var userRoleCreationRequest = new UserRoleCreationRequest(); // UserRoleCreationRequest | Definition of the user-role to create.

            try
            {
                // CreateUserRole: Create a user-role
                UserRoleResponse result = apiInstance.CreateUserRole(userRoleCreationRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling UserRolesApi.CreateUserRole: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    // CreateUserRole: Create a user-role
    ApiResponse<UserRoleResponse> response = apiInstance.CreateUserRoleWithHttpInfo(userRoleCreationRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling UserRolesApi.CreateUserRoleWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userRoleCreationRequest** | [**UserRoleCreationRequest**](UserRoleCreationRequest.md) | Definition of the user-role to create. |  |

### Return type

[**UserRoleResponse**](UserRoleResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User role that has been created. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deleteuserrole"></a>
# **DeleteUserRole**
> void DeleteUserRole (string userid)

DeleteUserRole: Delete a user-role

Deletes an identified user-role.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<UserRolesApi>();
            var userid = "userid_example";  // string | Id of the user-role to delete.

            try
            {
                // DeleteUserRole: Delete a user-role
                apiInstance.DeleteUserRole(userid);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling UserRolesApi.DeleteUserRole: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    // DeleteUserRole: Delete a user-role
    apiInstance.DeleteUserRoleWithHttpInfo(userid);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling UserRolesApi.DeleteUserRoleWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userid** | **string** | Id of the user-role to delete. |  |

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

<a id="getuserrole"></a>
# **GetUserRole**
> UserRoleResponse GetUserRole (string userid)

GetUserRole: Get a user-role

Get an identified user-role.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<UserRolesApi>();
            var userid = "userid_example";  // string | Id of the user-role to get.

            try
            {
                // GetUserRole: Get a user-role
                UserRoleResponse result = apiInstance.GetUserRole(userid);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling UserRolesApi.GetUserRole: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    // GetUserRole: Get a user-role
    ApiResponse<UserRoleResponse> response = apiInstance.GetUserRoleWithHttpInfo(userid);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling UserRolesApi.GetUserRoleWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userid** | **string** | Id of the user-role to get. |  |

### Return type

[**UserRoleResponse**](UserRoleResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested user role. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listuserroles"></a>
# **ListUserRoles**
> ResourceListOfUserRoleResponse ListUserRoles (string? filter = null, string? sortBy = null, int? limit = null, string? page = null)

ListUserRoles: List user-roles

Lists all user-roles and pages.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<UserRolesApi>();
            var filter = "filter_example";  // string? | Optional. Expression to filter the result set (optional) 
            var sortBy = "sortBy_example";  // string? | Optional. Order the results by these fields. Use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var page = "page_example";  // string? | Optional. Encoded page string returned from a previous search result that will retrieve              the next page of data. (optional) 

            try
            {
                // ListUserRoles: List user-roles
                ResourceListOfUserRoleResponse result = apiInstance.ListUserRoles(filter, sortBy, limit, page);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling UserRolesApi.ListUserRoles: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    // ListUserRoles: List user-roles
    ApiResponse<ResourceListOfUserRoleResponse> response = apiInstance.ListUserRolesWithHttpInfo(filter, sortBy, limit, page);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling UserRolesApi.ListUserRolesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
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

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="removepolicycollectionfromuserrole"></a>
# **RemovePolicyCollectionFromUserRole**
> void RemovePolicyCollectionFromUserRole (string userid, string policyCollectionScope, string policyCollectionCode)

RemovePolicyCollectionFromUserRole: Remove a policy collection from a user-role

Removes a policy collection from a user-role.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<UserRolesApi>();
            var userid = "userid_example";  // string | Id of the User Role to get
            var policyCollectionScope = "policyCollectionScope_example";  // string | The scope of policy collection to remove from the User Role
            var policyCollectionCode = "policyCollectionCode_example";  // string | The code of the policy collection to remove from the User Role

            try
            {
                // RemovePolicyCollectionFromUserRole: Remove a policy collection from a user-role
                apiInstance.RemovePolicyCollectionFromUserRole(userid, policyCollectionScope, policyCollectionCode);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling UserRolesApi.RemovePolicyCollectionFromUserRole: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    // RemovePolicyCollectionFromUserRole: Remove a policy collection from a user-role
    apiInstance.RemovePolicyCollectionFromUserRoleWithHttpInfo(userid, policyCollectionScope, policyCollectionCode);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling UserRolesApi.RemovePolicyCollectionFromUserRoleWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
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

<a id="removepolicyfromuserrole"></a>
# **RemovePolicyFromUserRole**
> void RemovePolicyFromUserRole (string userid, string policyScope, string policyCode)

RemovePolicyFromUserRole: Remove a policy from a user-role

Removes a policy from a user-role.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<UserRolesApi>();
            var userid = "userid_example";  // string | Id of the User Role to get
            var policyScope = "policyScope_example";  // string | The scope of the policy to remove from the User Role
            var policyCode = "policyCode_example";  // string | The code of the policy to remove from the User Role

            try
            {
                // RemovePolicyFromUserRole: Remove a policy from a user-role
                apiInstance.RemovePolicyFromUserRole(userid, policyScope, policyCode);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling UserRolesApi.RemovePolicyFromUserRole: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    // RemovePolicyFromUserRole: Remove a policy from a user-role
    apiInstance.RemovePolicyFromUserRoleWithHttpInfo(userid, policyScope, policyCode);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling UserRolesApi.RemovePolicyFromUserRoleWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
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

<a id="updateuserrole"></a>
# **UpdateUserRole**
> UserRoleResponse UpdateUserRole (string userid, UserRoleUpdateRequest userRoleUpdateRequest)

UpdateUserRole: Update a user-role

Updates an identified user-role.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<UserRolesApi>();
            var userid = "userid_example";  // string | Id of the user-role to be updated.
            var userRoleUpdateRequest = new UserRoleUpdateRequest(); // UserRoleUpdateRequest | Definition of the update to apply to the user-role.

            try
            {
                // UpdateUserRole: Update a user-role
                UserRoleResponse result = apiInstance.UpdateUserRole(userid, userRoleUpdateRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling UserRolesApi.UpdateUserRole: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    // UpdateUserRole: Update a user-role
    ApiResponse<UserRoleResponse> response = apiInstance.UpdateUserRoleWithHttpInfo(userid, userRoleUpdateRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling UserRolesApi.UpdateUserRoleWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userid** | **string** | Id of the user-role to be updated. |  |
| **userRoleUpdateRequest** | [**UserRoleUpdateRequest**](UserRoleUpdateRequest.md) | Definition of the update to apply to the user-role. |  |

### Return type

[**UserRoleResponse**](UserRoleResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User role that has been updated. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

