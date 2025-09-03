# Finbourne.Access.Sdk.Model.PolicyTemplateCreationRequest
Request to create a policy template

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The Code of the policy template being created | 
**DisplayName** | **string** | The display name of the policy template being created | 
**Description** | **string** | Description of the policy template being craeted | 
**TemplatedSelectors** | [**List&lt;PolicyTemplatedSelector&gt;**](PolicyTemplatedSelector.md) | The selector definitions of policies included in this policy template | 

```csharp
using Finbourne.Access.Sdk.Model;
using System;

string code = "code";
string displayName = "displayName";
string description = "description";
List<PolicyTemplatedSelector> templatedSelectors = new List<PolicyTemplatedSelector>();

PolicyTemplateCreationRequest policyTemplateCreationRequestInstance = new PolicyTemplateCreationRequest(
    code: code,
    displayName: displayName,
    description: description,
    templatedSelectors: templatedSelectors);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
