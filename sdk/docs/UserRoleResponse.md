# Finbourne.Access.Sdk.Model.UserRoleResponse
Response object from the user role API

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Resource** | [**RoleResourceRequest**](RoleResourceRequest.md) |  | 
**Id** | [**RoleId**](RoleId.md) |  | 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Finbourne.Access.Sdk.Model;
using System;

RoleResourceRequest resource = new RoleResourceRequest();
RoleId id = new RoleId();
List<Link> links = new List<Link>();

UserRoleResponse userRoleResponseInstance = new UserRoleResponse(
    resource: resource,
    id: id,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
