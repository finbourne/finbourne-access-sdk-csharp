# Finbourne.Access.Sdk.Api.LicencesApi

All URIs are relative to *https://www.lusid.com/access*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateLicence**](LicencesApi.md#createlicence) | **POST** /api/licences | [EXPERIMENTAL] Create a Licence
[**CreateLicenceAssignment**](LicencesApi.md#createlicenceassignment) | **PUT** /api/licences/{code}/assignments/{tenant} | [EXPERIMENTAL] Assign Licence
[**DeleteLicence**](LicencesApi.md#deletelicence) | **DELETE** /api/licences/{code} | [EXPERIMENTAL] Delete Licence
[**DeleteLicenceAssignment**](LicencesApi.md#deletelicenceassignment) | **DELETE** /api/licences/{code}/assignments/{tenant} | [EXPERIMENTAL] Unassign Licence
[**GetLicence**](LicencesApi.md#getlicence) | **GET** /api/licences/{code} | [EXPERIMENTAL] Get Licence
[**ListAssignments**](LicencesApi.md#listassignments) | **GET** /api/licences/{code}/assignments | [EXPERIMENTAL] List Assignments
[**ListLicences**](LicencesApi.md#listlicences) | **GET** /api/licences | [EXPERIMENTAL] List Licences
[**UpdateLicence**](LicencesApi.md#updatelicence) | **PUT** /api/licences/{code} | [EXPERIMENTAL] Update Licence



## CreateLicence

> PolicyResponse CreateLicence (LicenceCreationRequest licenceCreationRequest)

[EXPERIMENTAL] Create a Licence

Creates an unassigned Licence policy

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class CreateLicenceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LicencesApi(Configuration.Default);
            var licenceCreationRequest = new LicenceCreationRequest(); // LicenceCreationRequest | The Licence definition

            try
            {
                // [EXPERIMENTAL] Create a Licence
                PolicyResponse result = apiInstance.CreateLicence(licenceCreationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LicencesApi.CreateLicence: " + e.Message );
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
 **licenceCreationRequest** | [**LicenceCreationRequest**](LicenceCreationRequest.md)| The Licence definition | 

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
| **201** | Create a new Licence |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateLicenceAssignment

> PolicyResponse CreateLicenceAssignment (string code, string tenant)

[EXPERIMENTAL] Assign Licence

Create a licence assignment to another, authorised, tenant

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class CreateLicenceAssignmentExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LicencesApi(Configuration.Default);
            var code = code_example;  // string | Code of the Licence
            var tenant = tenant_example;  // string | Name of the tenant to be shared with

            try
            {
                // [EXPERIMENTAL] Assign Licence
                PolicyResponse result = apiInstance.CreateLicenceAssignment(code, tenant);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LicencesApi.CreateLicenceAssignment: " + e.Message );
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
 **code** | **string**| Code of the Licence | 
 **tenant** | **string**| Name of the tenant to be shared with | 

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
| **201** | Assign a Licence to a tenant |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteLicence

> void DeleteLicence (string code, string scope = null)

[EXPERIMENTAL] Delete Licence

Deletes an identified Licence

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class DeleteLicenceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LicencesApi(Configuration.Default);
            var code = code_example;  // string | The code of the Licence
            var scope = scope_example;  // string | Optional. Will use the client name if not provided. The scope of the Licence (optional) 

            try
            {
                // [EXPERIMENTAL] Delete Licence
                apiInstance.DeleteLicence(code, scope);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LicencesApi.DeleteLicence: " + e.Message );
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
 **code** | **string**| The code of the Licence | 
 **scope** | **string**| Optional. Will use the client name if not provided. The scope of the Licence | [optional] 

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


## DeleteLicenceAssignment

> void DeleteLicenceAssignment (string code, string tenant)

[EXPERIMENTAL] Unassign Licence

Remove a Licence assignment from a tenant

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class DeleteLicenceAssignmentExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LicencesApi(Configuration.Default);
            var code = code_example;  // string | Code of the Licence
            var tenant = tenant_example;  // string | Name of the tenant to be shared with

            try
            {
                // [EXPERIMENTAL] Unassign Licence
                apiInstance.DeleteLicenceAssignment(code, tenant);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LicencesApi.DeleteLicenceAssignment: " + e.Message );
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
 **code** | **string**| Code of the Licence | 
 **tenant** | **string**| Name of the tenant to be shared with | 

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


## GetLicence

> PolicyResponse GetLicence (string code, DateTimeOffset? asAt = null, string scope = null)

[EXPERIMENTAL] Get Licence

Gets an identified Licence

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class GetLicenceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LicencesApi(Configuration.Default);
            var code = code_example;  // string | The code of the Licence
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date time of the data (optional) 
            var scope = scope_example;  // string | Optional. Will use the default client name if not provided. The scope of the Licence (optional) 

            try
            {
                // [EXPERIMENTAL] Get Licence
                PolicyResponse result = apiInstance.GetLicence(code, asAt, scope);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LicencesApi.GetLicence: " + e.Message );
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
 **code** | **string**| The code of the Licence | 
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date time of the data | [optional] 
 **scope** | **string**| Optional. Will use the default client name if not provided. The scope of the Licence | [optional] 

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
| **200** | Get a specific Licence |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListAssignments

> ICollection&lt;string&gt; ListAssignments (string code)

[EXPERIMENTAL] List Assignments

List tenants the specified Licence is assigned to

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class ListAssignmentsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LicencesApi(Configuration.Default);
            var code = code_example;  // string | Code of the Licence

            try
            {
                // [EXPERIMENTAL] List Assignments
                ICollection<string> result = apiInstance.ListAssignments(code);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LicencesApi.ListAssignments: " + e.Message );
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
 **code** | **string**| Code of the Licence | 

### Return type

**ICollection<string>**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Get the list of tenants assigned to a licence |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListLicences

> ICollection&lt;PolicyResponse&gt; ListLicences (string assignedTo = null)

[EXPERIMENTAL] List Licences

Gets all Licences in a scope

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class ListLicencesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LicencesApi(Configuration.Default);
            var assignedTo = assignedTo_example;  // string | Optional. If specified, applies a filter for only Licences that are assigned to the specified tenant (optional) 

            try
            {
                // [EXPERIMENTAL] List Licences
                ICollection<PolicyResponse> result = apiInstance.ListLicences(assignedTo);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LicencesApi.ListLicences: " + e.Message );
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
 **assignedTo** | **string**| Optional. If specified, applies a filter for only Licences that are assigned to the specified tenant | [optional] 

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
| **200** | All of the licences in a scope |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateLicence

> PolicyResponse UpdateLicence (string code, LicenceUpdateRequest licenceUpdateRequest)

[EXPERIMENTAL] Update Licence

Update an existing Licence policy

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Client;
using Finbourne.Access.Sdk.Model;

namespace Example
{
    public class UpdateLicenceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://www.lusid.com/access";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LicencesApi(Configuration.Default);
            var code = code_example;  // string | The code of the Licence
            var licenceUpdateRequest = new LicenceUpdateRequest(); // LicenceUpdateRequest | The Licence definition

            try
            {
                // [EXPERIMENTAL] Update Licence
                PolicyResponse result = apiInstance.UpdateLicence(code, licenceUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LicencesApi.UpdateLicence: " + e.Message );
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
 **code** | **string**| The code of the Licence | 
 **licenceUpdateRequest** | [**LicenceUpdateRequest**](LicenceUpdateRequest.md)| The Licence definition | 

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
| **200** | Update a specific Licence |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

