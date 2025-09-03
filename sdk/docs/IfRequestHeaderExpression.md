# Finbourne.Access.Sdk.Model.IfRequestHeaderExpression

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HeaderName** | **string** |  | 
**Operator** | **TextOperator** |  | 
**Value** | **string** |  | [optional] 

```csharp
using Finbourne.Access.Sdk.Model;
using System;

string headerName = "headerName";
string value = "example value";

IfRequestHeaderExpression ifRequestHeaderExpressionInstance = new IfRequestHeaderExpression(
    headerName: headerName,
    operator: operator,
    value: value);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
