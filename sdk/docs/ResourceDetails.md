# Finbourne.Access.Sdk.Model.ResourceDetails
Details about the resource being requested that may be pertinent to the entitlement evaluation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Dictionary&lt;string, string&gt;** | The identifier of the resource being evaluated | 
**Metadata** | **Dictionary&lt;string, List&lt;EntitlementMetadata&gt;&gt;** | Any metadata associated with the resource being requested | [optional] 

```csharp
using Finbourne.Access.Sdk.Model;
using System;

Dictionary<string, string> id = new Dictionary<string, string>();
Dictionary<string, List<EntitlementMetadata>> metadata = new Dictionary<string, List<EntitlementMetadata>>();

ResourceDetails resourceDetailsInstance = new ResourceDetails(
    id: id,
    metadata: metadata);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
