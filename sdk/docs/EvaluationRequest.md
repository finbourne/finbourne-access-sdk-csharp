# Finbourne.Access.Sdk.Model.EvaluationRequest
Specification for a server side evaluation of entitlement.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Request** | [**RequestDetails**](RequestDetails.md) |  | 
**Resource** | [**ResourceDetails**](ResourceDetails.md) |  | 

```csharp
using Finbourne.Access.Sdk.Model;
using System;

RequestDetails request = new RequestDetails();
ResourceDetails resource = new ResourceDetails();

EvaluationRequest evaluationRequestInstance = new EvaluationRequest(
    request: request,
    resource: resource);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
