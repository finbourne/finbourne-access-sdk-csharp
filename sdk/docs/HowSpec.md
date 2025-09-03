# Finbourne.Access.Sdk.Model.HowSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | [optional] 
**Parameters** | [**List&lt;KeyValuePairOfStringToString&gt;**](KeyValuePairOfStringToString.md) |  | [optional] 

```csharp
using Finbourne.Access.Sdk.Model;
using System;

string type = "example type";
List<KeyValuePairOfStringToString> parameters = new List<KeyValuePairOfStringToString>();

HowSpec howSpecInstance = new HowSpec(
    type: type,
    parameters: parameters);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
