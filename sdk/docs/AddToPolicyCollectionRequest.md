# Finbourne.Access.Sdk.Model.AddToPolicyCollectionRequest
Base properties to create or update a policy collection

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Policies** | [**List&lt;PolicyId&gt;**](PolicyId.md) | The identifiers of the Policies to be added to the collection. | [optional] 
**PolicyCollections** | [**List&lt;PolicyCollectionId&gt;**](PolicyCollectionId.md) | The identifiers of the PolicyCollections to be added to the collection. | [optional] 

```csharp
using Finbourne.Access.Sdk.Model;
using System;

List<PolicyId> policies = new List<PolicyId>();
List<PolicyCollectionId> policyCollections = new List<PolicyCollectionId>();

AddToPolicyCollectionRequest addToPolicyCollectionRequestInstance = new AddToPolicyCollectionRequest(
    policies: policies,
    policyCollections: policyCollections);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
