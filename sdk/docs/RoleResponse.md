# Finbourne.Access.Sdk.Model.RoleResponse
Response object from the role API

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**RoleId**](RoleId.md) |  | 
**RoleHierarchyIndex** | **int** | The hierarchical index of the role | 
**Description** | **string** | The description of the role | [optional] 
**Resource** | [**RoleResourceRequest**](RoleResourceRequest.md) |  | 
**When** | [**WhenSpec**](WhenSpec.md) |  | 
**Permission** | **string** | The action key of the role | 
**Limit** | **Dictionary&lt;string, string&gt;** | The identifiers of the role with the maximum privileges that this role can have | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

