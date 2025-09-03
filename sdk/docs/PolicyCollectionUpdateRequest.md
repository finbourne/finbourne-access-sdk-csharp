# Finbourne.Access.Sdk.Model.PolicyCollectionUpdateRequest
Update an existing PolicyCollection

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Policies** | [**List&lt;PolicyId&gt;**](PolicyId.md) | The identifiers of the Policies in this collection | [optional] 
**Metadata** | **Dictionary&lt;string, List&lt;EntitlementMetadata&gt;&gt;** | Any relevant metadata associated with this resource for controlling access to this resource | [optional] 
**PolicyCollections** | [**List&lt;PolicyCollectionId&gt;**](PolicyCollectionId.md) | The identifiers of the PolicyCollections in this collection | [optional] 
**Description** | **string** | A description of this policy collection | [optional] 

```csharp
using Finbourne.Access.Sdk.Model;
using System;

List<PolicyId> policies = new List<PolicyId>();
Dictionary<string, List<EntitlementMetadata>> metadata = new Dictionary<string, List<EntitlementMetadata>>();
List<PolicyCollectionId> policyCollections = new List<PolicyCollectionId>();
string description = "example description";

PolicyCollectionUpdateRequest policyCollectionUpdateRequestInstance = new PolicyCollectionUpdateRequest(
    policies: policies,
    metadata: metadata,
    policyCollections: policyCollections,
    description: description);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
