# Finbourne.Access.Sdk.Model.IfExpression

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IfRequestHeaderExpression** | [**IfRequestHeaderExpression**](IfRequestHeaderExpression.md) |  | [optional] 
**IfIdentityClaimExpression** | [**IfIdentityClaimExpression**](IfIdentityClaimExpression.md) |  | [optional] 
**IfIdentityScopeExpression** | [**IfIdentityScopeExpression**](IfIdentityScopeExpression.md) |  | [optional] 
**IfViaApiExpression** | [**IfViaApiExpression**](IfViaApiExpression.md) |  | [optional] 

```csharp
using Finbourne.Access.Sdk.Model;
using System;

IfRequestHeaderExpression? ifRequestHeaderExpression = new IfRequestHeaderExpression();

IfIdentityClaimExpression? ifIdentityClaimExpression = new IfIdentityClaimExpression();

IfIdentityScopeExpression? ifIdentityScopeExpression = new IfIdentityScopeExpression();

IfViaApiExpression? ifViaApiExpression = new IfViaApiExpression();


IfExpression ifExpressionInstance = new IfExpression(
    ifRequestHeaderExpression: ifRequestHeaderExpression,
    ifIdentityClaimExpression: ifIdentityClaimExpression,
    ifIdentityScopeExpression: ifIdentityScopeExpression,
    ifViaApiExpression: ifViaApiExpression);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
