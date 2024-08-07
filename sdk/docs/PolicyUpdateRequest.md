# Finbourne.Access.Sdk.Model.PolicyUpdateRequest
Update policy request

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | Description of what the policy will be used for | [optional] 
**Applications** | **List&lt;string&gt;** | Applications this policy is used with | [optional] 
**Grant** | **Grant** |  | 
**Selectors** | [**List&lt;SelectorDefinition&gt;**](SelectorDefinition.md) | Selectors that identify what resources this policy qualifies for | 
**For** | [**List&lt;ForSpec&gt;**](ForSpec.md) | \&quot;For Specification\&quot; for when the policy is to be applied | [optional] 
**If** | [**List&lt;IfExpression&gt;**](IfExpression.md) | \&quot;If Specification\&quot; for when the policy is to be applied | [optional] 
**When** | [**WhenSpec**](WhenSpec.md) |  | 
**How** | [**HowSpec**](HowSpec.md) |  | [optional] 
**TemplateMetadata** | [**TemplateMetadata**](TemplateMetadata.md) |  | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

