# Finbourne.Access.Sdk.Model.IfExpression

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IfRequestHeaderExpression** | [**IfRequestHeaderExpression**](IfRequestHeaderExpression.md) |  | [optional] 
**IfIdentityClaimExpression** | [**IfIdentityClaimExpression**](IfIdentityClaimExpression.md) |  | [optional] 
**IfIdentityScopeExpression** | [**IfIdentityScopeExpression**](IfIdentityScopeExpression.md) |  | [optional] 
**IfFeatureChainExpression** | [**IfFeatureChainExpression**](IfFeatureChainExpression.md) |  | [optional] 

```csharp
using Finbourne.Access.Sdk.Model;
using System;

IfRequestHeaderExpression? ifRequestHeaderExpression = new IfRequestHeaderExpression();

IfIdentityClaimExpression? ifIdentityClaimExpression = new IfIdentityClaimExpression();

IfIdentityScopeExpression? ifIdentityScopeExpression = new IfIdentityScopeExpression();

IfFeatureChainExpression? ifFeatureChainExpression = new IfFeatureChainExpression();


IfExpression ifExpressionInstance = new IfExpression(
    ifRequestHeaderExpression: ifRequestHeaderExpression,
    ifIdentityClaimExpression: ifIdentityClaimExpression,
    ifIdentityScopeExpression: ifIdentityScopeExpression,
    ifFeatureChainExpression: ifFeatureChainExpression);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
