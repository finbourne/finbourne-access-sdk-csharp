# Finbourne.Access.Sdk.Model.PolicyIdRoleResource

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Policies** | [**List&lt;PolicyId&gt;**](PolicyId.md) |  | [optional] 
**PolicyCollections** | [**List&lt;PolicyCollectionId&gt;**](PolicyCollectionId.md) |  | [optional] 

```csharp
using Finbourne.Access.Sdk.Model;
using System;

List<PolicyId> policies = new List<PolicyId>();
List<PolicyCollectionId> policyCollections = new List<PolicyCollectionId>();

PolicyIdRoleResource policyIdRoleResourceInstance = new PolicyIdRoleResource(
    policies: policies,
    policyCollections: policyCollections);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
