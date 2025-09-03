# Finbourne.Access.Sdk.Model.PolicyResponse
Response object from the policy API

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**PolicyId**](PolicyId.md) |  | [optional] 
**Description** | **string** | Description of what the policy is entitling | [optional] 
**Applications** | **List&lt;string&gt;** | Applications to which the policy applies | [optional] 
**Grant** | **Grant** |  | [optional] 
**Selectors** | [**List&lt;SelectorDefinition&gt;**](SelectorDefinition.md) | Selectors that this policy will be applied to | [optional] 
**For** | [**List&lt;ForSpec&gt;**](ForSpec.md) | \&quot;For Specification\&quot; for when the policy is to be applied | [optional] 
**If** | [**List&lt;IfExpression&gt;**](IfExpression.md) | \&quot;If Specification\&quot; for when the policy is to be applied | [optional] 
**When** | [**WhenSpec**](WhenSpec.md) |  | [optional] 
**How** | [**HowSpec**](HowSpec.md) |  | [optional] 
**TemplateMetadata** | [**TemplateMetadata**](TemplateMetadata.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Finbourne.Access.Sdk.Model;
using System;

PolicyId? id = new PolicyId();

string description = "example description";
List<string> applications = new List<string>();
List<SelectorDefinition> selectors = new List<SelectorDefinition>();
List<ForSpec> for = new List<ForSpec>();
List<IfExpression> if = new List<IfExpression>();
WhenSpec? when = new WhenSpec();

HowSpec? how = new HowSpec();

TemplateMetadata? templateMetadata = new TemplateMetadata();

List<Link> links = new List<Link>();

PolicyResponse policyResponseInstance = new PolicyResponse(
    id: id,
    description: description,
    applications: applications,
    grant: grant,
    selectors: selectors,
    for: for,
    if: if,
    when: when,
    how: how,
    templateMetadata: templateMetadata,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
