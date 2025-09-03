# Finbourne.Access.Sdk.Model.AddPolicyToRoleRequest
Request body used to add Policies to a Role

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Policies** | [**List&lt;PolicyId&gt;**](PolicyId.md) | Identifiers of policies to add to a role | 

```csharp
using Finbourne.Access.Sdk.Model;
using System;

List<PolicyId> policies = new List<PolicyId>();

AddPolicyToRoleRequest addPolicyToRoleRequestInstance = new AddPolicyToRoleRequest(
    policies: policies);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
