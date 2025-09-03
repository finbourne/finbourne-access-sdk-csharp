# Finbourne.Access.Sdk.Model.IfIdentityClaimExpression

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClaimType** | **string** |  | 
**ClaimValueType** | **string** |  | [optional] 
**ClaimIssuer** | **string** |  | [optional] 
**ClaimOriginalIssuer** | **string** |  | [optional] 
**Operator** | **TextOperator** |  | 
**Value** | **string** |  | [optional] 

```csharp
using Finbourne.Access.Sdk.Model;
using System;

string claimType = "claimType";
string claimValueType = "example claimValueType";
string claimIssuer = "example claimIssuer";
string claimOriginalIssuer = "example claimOriginalIssuer";
string value = "example value";

IfIdentityClaimExpression ifIdentityClaimExpressionInstance = new IfIdentityClaimExpression(
    claimType: claimType,
    claimValueType: claimValueType,
    claimIssuer: claimIssuer,
    claimOriginalIssuer: claimOriginalIssuer,
    operator: operator,
    value: value);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
