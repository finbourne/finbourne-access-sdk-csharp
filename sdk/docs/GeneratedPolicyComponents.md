# Finbourne.Access.Sdk.Model.GeneratedPolicyComponents
Response object for policy generated from template

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Applications** | **List&lt;string&gt;** | Applications to which the policy applies | [optional] 
**TemplateMetadata** | [**TemplateMetadata**](TemplateMetadata.md) |  | [optional] 
**Selectors** | [**List&lt;SelectorDefinition&gt;**](SelectorDefinition.md) | Selectors that this policy will be applied to | [optional] 

```csharp
using Finbourne.Access.Sdk.Model;
using System;

List<string> applications = new List<string>();
TemplateMetadata? templateMetadata = new TemplateMetadata();

List<SelectorDefinition> selectors = new List<SelectorDefinition>();

GeneratedPolicyComponents generatedPolicyComponentsInstance = new GeneratedPolicyComponents(
    applications: applications,
    templateMetadata: templateMetadata,
    selectors: selectors);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
