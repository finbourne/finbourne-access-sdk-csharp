# Finbourne.Access.Sdk.Model.RequestDetails
The details of the requested evaluation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | [**RequestedActionKey**](RequestedActionKey.md) |  | 
**FromEffectiveDate** | **DateTimeOffset?** | The start date for the requested effective date range for the resource (if null, UtcNow) | [optional] 
**ToEffectiveDate** | **DateTimeOffset?** | The end date for the requested effective date range for the resource (if null, same as from date) | [optional] 
**FromAsAt** | **DateTimeOffset?** | The requested AsAt date for the resource (if null, Latest). If specifying a range of AsAt dates, this is the lower bounds. | [optional] 
**ToAsAt** | **DateTimeOffset?** | Upper bound if specifying a request that requires a range of AsAt dates. This is used if specifying the desire to grant access for a user between an AsAt range. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

