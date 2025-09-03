# Finbourne.Access.Sdk.Model.RequestedActionKey
A fully qualified action identifier

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityCode** | **string** | The type of the resource on which the activity would be performed | 
**Scope** | **string** | The scope/provider/vendor of the activity | 
**Activity** | **string** | The identifier of the action to be performed on the resource | 

```csharp
using Finbourne.Access.Sdk.Model;
using System;

string entityCode = "entityCode";
string scope = "scope";
string activity = "activity";

RequestedActionKey requestedActionKeyInstance = new RequestedActionKey(
    entityCode: entityCode,
    scope: scope,
    activity: activity);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
