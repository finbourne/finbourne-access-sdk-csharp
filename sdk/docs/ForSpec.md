# Finbourne.Access.Sdk.Model.ForSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AsAtRangeForSpec** | [**AsAtRangeForSpec**](AsAtRangeForSpec.md) |  | [optional] 
**AsAtRelative** | [**AsAtRelative**](AsAtRelative.md) |  | [optional] 
**EffectiveDateHasQuality** | [**EffectiveDateHasQuality**](EffectiveDateHasQuality.md) |  | [optional] 
**EffectiveDateRelative** | [**EffectiveDateRelative**](EffectiveDateRelative.md) |  | [optional] 
**EffectiveRange** | [**EffectiveRange**](EffectiveRange.md) |  | [optional] 

```csharp
using Finbourne.Access.Sdk.Model;
using System;

AsAtRangeForSpec? asAtRangeForSpec = new AsAtRangeForSpec();

AsAtRelative? asAtRelative = new AsAtRelative();

EffectiveDateHasQuality? effectiveDateHasQuality = new EffectiveDateHasQuality();

EffectiveDateRelative? effectiveDateRelative = new EffectiveDateRelative();

EffectiveRange? effectiveRange = new EffectiveRange();


ForSpec forSpecInstance = new ForSpec(
    asAtRangeForSpec: asAtRangeForSpec,
    asAtRelative: asAtRelative,
    effectiveDateHasQuality: effectiveDateHasQuality,
    effectiveDateRelative: effectiveDateRelative,
    effectiveRange: effectiveRange);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
