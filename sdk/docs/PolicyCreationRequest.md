# Finbourne.Access.Sdk.Model.PolicyCreationRequest
Request to create a policy

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | Code of the policy being created | 
**Description** | **string** | Description of what the policy will be used for | [optional] 
**Applications** | **List&lt;string&gt;** | Applications this policy is used with | [optional] 
**Grant** | **Grant** |  | 
**Selectors** | [**List&lt;SelectorDefinition&gt;**](SelectorDefinition.md) | Selectors that identify what resources this policy qualifies for | 
**For** | [**List&lt;ForSpec&gt;**](ForSpec.md) | \&quot;For Specification\&quot; for when the policy is to be applied | [optional] 
**If** | [**List&lt;IfExpression&gt;**](IfExpression.md) | \&quot;If Specification\&quot; for when the policy is to be applied | [optional] 
**When** | [**WhenSpec**](WhenSpec.md) |  | 
**How** | [**HowSpec**](HowSpec.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

