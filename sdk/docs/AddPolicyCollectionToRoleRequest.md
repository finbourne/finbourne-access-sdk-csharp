# Finbourne.Access.Sdk.Model.AddPolicyCollectionToRoleRequest
Request body used to add Policy Collections to a Role

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PolicyCollections** | [**List&lt;PolicyCollectionId&gt;**](PolicyCollectionId.md) | Identifiers of policy collections to add to a role | 

```csharp
using Finbourne.Access.Sdk.Model;
using System;

List<PolicyCollectionId> policyCollections = new List<PolicyCollectionId>();

AddPolicyCollectionToRoleRequest addPolicyCollectionToRoleRequestInstance = new AddPolicyCollectionToRoleRequest(
    policyCollections: policyCollections);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
