# Finbourne.Access.Sdk.Model.MetadataExpression

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MetadataKey** | **string** |  | 
**Operator** | **Operator** |  | 
**TextValue** | **string** |  | [optional] 

```csharp
using Finbourne.Access.Sdk.Model;
using System;

string metadataKey = "metadataKey";
string textValue = "example textValue";

MetadataExpression metadataExpressionInstance = new MetadataExpression(
    metadataKey: metadataKey,
    operator: operator,
    textValue: textValue);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
