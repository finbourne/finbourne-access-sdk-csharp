# Finbourne.Access.Sdk.Api.RolesApi

All URIs are relative to *https://fbn-prd.lusid.com/access*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddPolicyCollectionToRole**](RolesApi.md#addpolicycollectiontorole) | **POST** /api/roles/{scope}/{code}/policycollections | AddPolicyCollectionToRole: Add policy collections to a role |
| [**CreateRole**](RolesApi.md#createrole) | **POST** /api/roles | CreateRole: Create Role |
| [**DeleteRole**](RolesApi.md#deleterole) | **DELETE** /api/roles/{code} | DeleteRole: Delete Role |
| [**GetRole**](RolesApi.md#getrole) | **GET** /api/roles/{code} | GetRole: Get Role |
| [**ListRoles**](RolesApi.md#listroles) | **GET** /api/roles | ListRoles: List Roles |
| [**RemovePolicyCollectionFromRole**](RolesApi.md#removepolicycollectionfromrole) | **DELETE** /api/roles/{scope}/{code}/policycollections/{policycollectionscope}/{policycollectioncode} | RemovePolicyCollectionFromRole: Remove policy collection from role |
| [**UpdateRole**](RolesApi.md#updaterole) | **PUT** /api/roles/{code} | UpdateRole: Update Role |

<a id="addpolicycollectiontorole"></a>
# **AddPolicyCollectionToRole**
> RoleResponse AddPolicyCollectionToRole (string scope, string code, AddPolicyCollectionToRoleRequest addPolicyCollectionToRoleRequest)

AddPolicyCollectionToRole: Add policy collections to a role

Assigns policy collections to a role

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<RolesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<RolesApi>();
            var scope = "scope_example";  // string | The scope of the Role
            var code = "code_example";  // string | The code of the Role
            var addPolicyCollectionToRoleRequest = new AddPolicyCollectionToRoleRequest(); // AddPolicyCollectionToRoleRequest | The policy collections to add

            try
            {
                // uncomment the below to set overrides at the request level
                // RoleResponse result = apiInstance.AddPolicyCollectionToRole(scope, code, addPolicyCollectionToRoleRequest, opts: opts);

                // AddPolicyCollectionToRole: Add policy collections to a role
                RoleResponse result = apiInstance.AddPolicyCollectionToRole(scope, code, addPolicyCollectionToRoleRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RolesApi.AddPolicyCollectionToRole: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddPolicyCollectionToRoleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // AddPolicyCollectionToRole: Add policy collections to a role
    ApiResponse<RoleResponse> response = apiInstance.AddPolicyCollectionToRoleWithHttpInfo(scope, code, addPolicyCollectionToRoleRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RolesApi.AddPolicyCollectionToRoleWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Role |  |
| **code** | **string** | The code of the Role |  |
| **addPolicyCollectionToRoleRequest** | [**AddPolicyCollectionToRoleRequest**](AddPolicyCollectionToRoleRequest.md) | The policy collections to add |  |

### Return type

[**RoleResponse**](RoleResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | AddPolicyCollectionToRole |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="createrole"></a>
# **CreateRole**
> RoleResponse CreateRole (RoleCreationRequest roleCreationRequest)

CreateRole: Create Role

Creates a Role

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<RolesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<RolesApi>();
            var roleCreationRequest = new RoleCreationRequest(); // RoleCreationRequest | The definition of the Role

            try
            {
                // uncomment the below to set overrides at the request level
                // RoleResponse result = apiInstance.CreateRole(roleCreationRequest, opts: opts);

                // CreateRole: Create Role
                RoleResponse result = apiInstance.CreateRole(roleCreationRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RolesApi.CreateRole: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateRoleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CreateRole: Create Role
    ApiResponse<RoleResponse> response = apiInstance.CreateRoleWithHttpInfo(roleCreationRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RolesApi.CreateRoleWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **roleCreationRequest** | [**RoleCreationRequest**](RoleCreationRequest.md) | The definition of the Role |  |

### Return type

[**RoleResponse**](RoleResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created Role |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deleterole"></a>
# **DeleteRole**
> void DeleteRole (string code, string? scope = null)

DeleteRole: Delete Role

Deletes an identified Role

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<RolesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<RolesApi>();
            var code = "code_example";  // string | The code of the Role
            var scope = "scope_example";  // string? | >Optional. Will use default scope if not supplied. The scope of the Role (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // apiInstance.DeleteRole(code, scope, opts: opts);

                // DeleteRole: Delete Role
                apiInstance.DeleteRole(code, scope);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RolesApi.DeleteRole: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteRoleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DeleteRole: Delete Role
    apiInstance.DeleteRoleWithHttpInfo(code, scope);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RolesApi.DeleteRoleWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | The code of the Role |  |
| **scope** | **string?** | &gt;Optional. Will use default scope if not supplied. The scope of the Role | [optional]  |

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

<a id="getrole"></a>
# **GetRole**
> RoleResponse GetRole (string code, string? scope = null)

GetRole: Get Role

Gets an identified Role

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<RolesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<RolesApi>();
            var code = "code_example";  // string | The code of the Role
            var scope = "scope_example";  // string? | Optional. Will use default scope if not supplied. The scope of the Role (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // RoleResponse result = apiInstance.GetRole(code, scope, opts: opts);

                // GetRole: Get Role
                RoleResponse result = apiInstance.GetRole(code, scope);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RolesApi.GetRole: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRoleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetRole: Get Role
    ApiResponse<RoleResponse> response = apiInstance.GetRoleWithHttpInfo(code, scope);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RolesApi.GetRoleWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | The code of the Role |  |
| **scope** | **string?** | Optional. Will use default scope if not supplied. The scope of the Role | [optional]  |

### Return type

[**RoleResponse**](RoleResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Requested Role |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listroles"></a>
# **ListRoles**
> List&lt;RoleResponse&gt; ListRoles (string? scope = null)

ListRoles: List Roles

Gets all Roles in a scope

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<RolesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<RolesApi>();
            var scope = "scope_example";  // string? | Optional. Will use all scopes if not supplied. The requested scope (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // List<RoleResponse> result = apiInstance.ListRoles(scope, opts: opts);

                // ListRoles: List Roles
                List<RoleResponse> result = apiInstance.ListRoles(scope);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RolesApi.ListRoles: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListRolesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListRoles: List Roles
    ApiResponse<List<RoleResponse>> response = apiInstance.ListRolesWithHttpInfo(scope);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RolesApi.ListRolesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string?** | Optional. Will use all scopes if not supplied. The requested scope | [optional]  |

### Return type

[**List&lt;RoleResponse&gt;**](RoleResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of Roles |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="removepolicycollectionfromrole"></a>
# **RemovePolicyCollectionFromRole**
> RoleResponse RemovePolicyCollectionFromRole (string scope, string code, string policycollectionscope, string policycollectioncode)

RemovePolicyCollectionFromRole: Remove policy collection from role

Removes a policy collection from a role

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<RolesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<RolesApi>();
            var scope = "scope_example";  // string | The scope of the Role
            var code = "code_example";  // string | The code of the Role
            var policycollectionscope = "policycollectionscope_example";  // string | The scope of policy collection to remove from the Role
            var policycollectioncode = "policycollectioncode_example";  // string | The code of the policy collection to remove from the Role

            try
            {
                // uncomment the below to set overrides at the request level
                // RoleResponse result = apiInstance.RemovePolicyCollectionFromRole(scope, code, policycollectionscope, policycollectioncode, opts: opts);

                // RemovePolicyCollectionFromRole: Remove policy collection from role
                RoleResponse result = apiInstance.RemovePolicyCollectionFromRole(scope, code, policycollectionscope, policycollectioncode);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RolesApi.RemovePolicyCollectionFromRole: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemovePolicyCollectionFromRoleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // RemovePolicyCollectionFromRole: Remove policy collection from role
    ApiResponse<RoleResponse> response = apiInstance.RemovePolicyCollectionFromRoleWithHttpInfo(scope, code, policycollectionscope, policycollectioncode);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RolesApi.RemovePolicyCollectionFromRoleWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Role |  |
| **code** | **string** | The code of the Role |  |
| **policycollectionscope** | **string** | The scope of policy collection to remove from the Role |  |
| **policycollectioncode** | **string** | The code of the policy collection to remove from the Role |  |

### Return type

[**RoleResponse**](RoleResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | RemovePolicyCollectionFromRole |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updaterole"></a>
# **UpdateRole**
> RoleResponse UpdateRole (string code, RoleUpdateRequest roleUpdateRequest, string? scope = null, string? beforeScope = null, string? beforeCode = null, string? afterScope = null, string? afterCode = null)

UpdateRole: Update Role

Updates a Role

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<RolesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<RolesApi>();
            var code = "code_example";  // string | The code of the Role
            var roleUpdateRequest = new RoleUpdateRequest(); // RoleUpdateRequest | The updated definition of the Role
            var scope = "scope_example";  // string? | >Optional. Will use default scope if not supplied. The scope of the Role (optional) 
            var beforeScope = "beforeScope_example";  // string? | Optional. The scope of the Role. Will use default scope if not supplied. (optional) 
            var beforeCode = "beforeCode_example";  // string? | Optional. The code of the Role (optional) 
            var afterScope = "afterScope_example";  // string? | Optional. The scope of the Role. Will use default scope if not supplied. (optional) 
            var afterCode = "afterCode_example";  // string? | Optional. The code of the Role (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // RoleResponse result = apiInstance.UpdateRole(code, roleUpdateRequest, scope, beforeScope, beforeCode, afterScope, afterCode, opts: opts);

                // UpdateRole: Update Role
                RoleResponse result = apiInstance.UpdateRole(code, roleUpdateRequest, scope, beforeScope, beforeCode, afterScope, afterCode);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RolesApi.UpdateRole: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateRoleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // UpdateRole: Update Role
    ApiResponse<RoleResponse> response = apiInstance.UpdateRoleWithHttpInfo(code, roleUpdateRequest, scope, beforeScope, beforeCode, afterScope, afterCode);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RolesApi.UpdateRoleWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | The code of the Role |  |
| **roleUpdateRequest** | [**RoleUpdateRequest**](RoleUpdateRequest.md) | The updated definition of the Role |  |
| **scope** | **string?** | &gt;Optional. Will use default scope if not supplied. The scope of the Role | [optional]  |
| **beforeScope** | **string?** | Optional. The scope of the Role. Will use default scope if not supplied. | [optional]  |
| **beforeCode** | **string?** | Optional. The code of the Role | [optional]  |
| **afterScope** | **string?** | Optional. The scope of the Role. Will use default scope if not supplied. | [optional]  |
| **afterCode** | **string?** | Optional. The code of the Role | [optional]  |

### Return type

[**RoleResponse**](RoleResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated Role |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

