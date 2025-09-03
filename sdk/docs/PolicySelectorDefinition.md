# Finbourne.Access.Sdk.Model.PolicySelectorDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IdentityRestriction** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**RestrictionSelectors** | [**List&lt;SelectorDefinition&gt;**](SelectorDefinition.md) |  | [optional] 
**Actions** | [**List&lt;ActionId&gt;**](ActionId.md) |  | 
**Name** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 

```csharp
using Finbourne.Access.Sdk.Model;
using System;

Dictionary<string, string> identityRestriction = new Dictionary<string, string>();
List<SelectorDefinition> restrictionSelectors = new List<SelectorDefinition>();
List<ActionId> actions = new List<ActionId>();
string name = "example name";
string description = "example description";

PolicySelectorDefinition policySelectorDefinitionInstance = new PolicySelectorDefinition(
    identityRestriction: identityRestriction,
    restrictionSelectors: restrictionSelectors,
    actions: actions,
    name: name,
    description: description);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
