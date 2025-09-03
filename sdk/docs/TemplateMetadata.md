# Finbourne.Access.Sdk.Model.TemplateMetadata
Extra policy template metadata information, used during a generation request

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TemplateSelection** | [**List&lt;TemplateSelection&gt;**](TemplateSelection.md) | List of policy templates used for a generation request | [optional] 
**BuildAsAt** | **DateTimeOffset** | Policy template build AsAt time used for a generation request | [optional] 

```csharp
using Finbourne.Access.Sdk.Model;
using System;

List<TemplateSelection> templateSelection = new List<TemplateSelection>();

TemplateMetadata templateMetadataInstance = new TemplateMetadata(
    templateSelection: templateSelection,
    buildAsAt: buildAsAt);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
