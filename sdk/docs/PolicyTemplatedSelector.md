# Finbourne.Access.Sdk.Model.PolicyTemplatedSelector
Templated selector for a policy template

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Application** | **string** | The application that this selector definition applies to | 
**Tag** | **string** | The type of policy that this selector definition applies to | 
**Selector** | [**SelectorDefinition**](SelectorDefinition.md) |  | 

```csharp
using Finbourne.Access.Sdk.Model;
using System;

string application = "application";
string tag = "tag";
SelectorDefinition selector = new SelectorDefinition();

PolicyTemplatedSelector policyTemplatedSelectorInstance = new PolicyTemplatedSelector(
    application: application,
    tag: tag,
    selector: selector);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
