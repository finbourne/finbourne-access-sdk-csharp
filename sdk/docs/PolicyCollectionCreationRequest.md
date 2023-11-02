# Finbourne.Access.Sdk.Model.PolicyCollectionCreationRequest
Create a PolicyCollection, a logical group of Policies or other PolicyCollections

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The identifier for the PolicyCollection being created | 
**Policies** | [**List&lt;PolicyId&gt;**](PolicyId.md) | The identifiers of the Policies in this collection | [optional] 
**Metadata** | **Dictionary&lt;string, List&lt;EntitlementMetadata&gt;&gt;** | Any relevant metadata associated with this resource for controlling access to this resource | [optional] 
**PolicyCollections** | [**List&lt;PolicyCollectionId&gt;**](PolicyCollectionId.md) | The identifiers of the PolicyCollections in this collection | [optional] 
**Description** | **string** | A description of this policy collection | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

