# Finbourne.Access.Sdk.Model.SelectorDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MetadataSelectorDefinition** | [**MetadataSelectorDefinition**](MetadataSelectorDefinition.md) |  | [optional] 
**IdSelectorDefinition** | [**IdSelectorDefinition**](IdSelectorDefinition.md) |  | [optional] 
**MatchAllSelectorDefinition** | [**MatchAllSelectorDefinition**](MatchAllSelectorDefinition.md) |  | [optional] 
**PolicySelectorDefinition** | [**PolicySelectorDefinition**](PolicySelectorDefinition.md) |  | [optional] 

```csharp
using Finbourne.Access.Sdk.Model;
using System;

MetadataSelectorDefinition? metadataSelectorDefinition = new MetadataSelectorDefinition();

IdSelectorDefinition? idSelectorDefinition = new IdSelectorDefinition();

MatchAllSelectorDefinition? matchAllSelectorDefinition = new MatchAllSelectorDefinition();

PolicySelectorDefinition? policySelectorDefinition = new PolicySelectorDefinition();


SelectorDefinition selectorDefinitionInstance = new SelectorDefinition(
    metadataSelectorDefinition: metadataSelectorDefinition,
    idSelectorDefinition: idSelectorDefinition,
    matchAllSelectorDefinition: matchAllSelectorDefinition,
    policySelectorDefinition: policySelectorDefinition);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
