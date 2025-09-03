# Finbourne.Access.Sdk.Model.RoleResponse
Response object from the role API

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**RoleId**](RoleId.md) |  | 
**RoleHierarchyIndex** | **int** | The hierarchical index of the role | 
**Description** | **string** | The description of the role | [optional] 
**Resource** | [**RoleResourceRequest**](RoleResourceRequest.md) |  | 
**When** | [**WhenSpec**](WhenSpec.md) |  | 
**Permission** | **string** | The action key of the role | 
**Limit** | **Dictionary&lt;string, string&gt;** | The identifiers of the role with the maximum privileges that this role can have | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Finbourne.Access.Sdk.Model;
using System;

RoleId id = new RoleId();
string description = "example description";
RoleResourceRequest resource = new RoleResourceRequest();
WhenSpec when = new WhenSpec();
string permission = "permission";
Dictionary<string, string> limit = new Dictionary<string, string>();
List<Link> links = new List<Link>();

RoleResponse roleResponseInstance = new RoleResponse(
    id: id,
    roleHierarchyIndex: roleHierarchyIndex,
    description: description,
    resource: resource,
    when: when,
    permission: permission,
    limit: limit,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
