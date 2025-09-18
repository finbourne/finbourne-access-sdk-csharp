# Finbourne.Access.Sdk.Model.TemplateSelection
A template selection, identifying a policy template to use for generation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Scope** | **string** | Scope identifying policy template to use for generation | 
**Code** | **string** | Code identifying policy template to use for generation | 
**SelectorTags** | **List&lt;string&gt;** | List of selector tags to optionally filter in the template generation  (Eg: Feature, Data, etc) | [optional] 

```csharp
using Finbourne.Access.Sdk.Model;
using System;

string scope = "scope";
string code = "code";
List<string> selectorTags = new List<string>();

TemplateSelection templateSelectionInstance = new TemplateSelection(
    scope: scope,
    code: code,
    selectorTags: selectorTags);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
