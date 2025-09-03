# Finbourne.Access.Sdk.Model.MatchAllSelectorDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Actions** | [**List&lt;ActionId&gt;**](ActionId.md) |  | 
**Name** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 

```csharp
using Finbourne.Access.Sdk.Model;
using System;

List<ActionId> actions = new List<ActionId>();
string name = "example name";
string description = "example description";

MatchAllSelectorDefinition matchAllSelectorDefinitionInstance = new MatchAllSelectorDefinition(
    actions: actions,
    name: name,
    description: description);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
