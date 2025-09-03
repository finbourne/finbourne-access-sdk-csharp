# Finbourne.Access.Sdk.Model.AttachedPolicyDefinitionResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceRole** | [**RoleId**](RoleId.md) |  | [optional] 
**RoleHierarchyIndex** | **int** |  | [optional] 
**Description** | **string** |  | [optional] 
**Applications** | **List&lt;string&gt;** |  | [optional] 
**PolicyType** | **PolicyType** |  | [optional] 
**Id** | [**PolicyId**](PolicyId.md) |  | [optional] 
**Grant** | **Grant** |  | [optional] 
**Selectors** | [**List&lt;SelectorDefinition&gt;**](SelectorDefinition.md) |  | [optional] 
**For** | [**List&lt;ForSpec&gt;**](ForSpec.md) |  | [optional] 
**If** | [**List&lt;IfExpression&gt;**](IfExpression.md) |  | [optional] 
**When** | [**WhenSpec**](WhenSpec.md) |  | [optional] 
**How** | [**HowSpec**](HowSpec.md) |  | [optional] 

```csharp
using Finbourne.Access.Sdk.Model;
using System;

RoleId? sourceRole = new RoleId();

string description = "example description";
List<string> applications = new List<string>();
PolicyId? id = new PolicyId();

List<SelectorDefinition> selectors = new List<SelectorDefinition>();
List<ForSpec> for = new List<ForSpec>();
List<IfExpression> if = new List<IfExpression>();
WhenSpec? when = new WhenSpec();

HowSpec? how = new HowSpec();


AttachedPolicyDefinitionResponse attachedPolicyDefinitionResponseInstance = new AttachedPolicyDefinitionResponse(
    sourceRole: sourceRole,
    roleHierarchyIndex: roleHierarchyIndex,
    description: description,
    applications: applications,
    policyType: policyType,
    id: id,
    grant: grant,
    selectors: selectors,
    for: for,
    if: if,
    when: when,
    how: how);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
