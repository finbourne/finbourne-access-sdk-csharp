# Finbourne.Access.Sdk.Model.RoleResourceRequest
RoleResourceRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NonTransitiveSupervisorRoleResource** | [**NonTransitiveSupervisorRoleResource**](NonTransitiveSupervisorRoleResource.md) |  | [optional] 
**PolicyIdRoleResource** | [**PolicyIdRoleResource**](PolicyIdRoleResource.md) |  | [optional] 

```csharp
using Finbourne.Access.Sdk.Model;
using System;

NonTransitiveSupervisorRoleResource? nonTransitiveSupervisorRoleResource = new NonTransitiveSupervisorRoleResource();

PolicyIdRoleResource? policyIdRoleResource = new PolicyIdRoleResource();


RoleResourceRequest roleResourceRequestInstance = new RoleResourceRequest(
    nonTransitiveSupervisorRoleResource: nonTransitiveSupervisorRoleResource,
    policyIdRoleResource: policyIdRoleResource);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
