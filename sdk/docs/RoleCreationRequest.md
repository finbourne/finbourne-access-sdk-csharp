# Finbourne.Access.Sdk.Model.RoleCreationRequest
Request to create a role

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The code of the role | 
**Description** | **string** | The description of the role | [optional] 
**Resource** | [**RoleResourceRequest**](RoleResourceRequest.md) |  | 
**When** | [**WhenSpec**](WhenSpec.md) |  | 

```csharp
using Finbourne.Access.Sdk.Model;
using System;

string code = "code";
string description = "example description";
RoleResourceRequest resource = new RoleResourceRequest();
WhenSpec when = new WhenSpec();

RoleCreationRequest roleCreationRequestInstance = new RoleCreationRequest(
    code: code,
    description: description,
    resource: resource,
    when: when);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
