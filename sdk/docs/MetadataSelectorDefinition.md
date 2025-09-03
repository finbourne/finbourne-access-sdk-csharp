# Finbourne.Access.Sdk.Model.MetadataSelectorDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Expressions** | [**List&lt;MetadataExpression&gt;**](MetadataExpression.md) |  | 
**Actions** | [**List&lt;ActionId&gt;**](ActionId.md) |  | 
**Name** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 

```csharp
using Finbourne.Access.Sdk.Model;
using System;

List<MetadataExpression> expressions = new List<MetadataExpression>();
List<ActionId> actions = new List<ActionId>();
string name = "example name";
string description = "example description";

MetadataSelectorDefinition metadataSelectorDefinitionInstance = new MetadataSelectorDefinition(
    expressions: expressions,
    actions: actions,
    name: name,
    description: description);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
