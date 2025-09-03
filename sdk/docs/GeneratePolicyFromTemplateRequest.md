# Finbourne.Access.Sdk.Model.GeneratePolicyFromTemplateRequest
Generate policy from template

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TemplateSelection** | [**List&lt;TemplateSelection&gt;**](TemplateSelection.md) | List of template selection, identifying policy templates to use for generation | 
**Selectors** | [**List&lt;SelectorDefinition&gt;**](SelectorDefinition.md) | List of additional selectors to be included in the policy | [optional] 

```csharp
using Finbourne.Access.Sdk.Model;
using System;

List<TemplateSelection> templateSelection = new List<TemplateSelection>();
List<SelectorDefinition> selectors = new List<SelectorDefinition>();

GeneratePolicyFromTemplateRequest generatePolicyFromTemplateRequestInstance = new GeneratePolicyFromTemplateRequest(
    templateSelection: templateSelection,
    selectors: selectors);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
