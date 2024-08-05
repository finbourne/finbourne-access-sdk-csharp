<a id="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://fbn-prd.lusid.com/access*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ApplicationMetadataApi* | [**ListAccessControlledResources**](docs/ApplicationMetadataApi.md#listaccesscontrolledresources) | **GET** /api/metadata/access/resources | ListAccessControlledResources: Get resources available for access control
*PoliciesApi* | [**AddToPolicyCollection**](docs/PoliciesApi.md#addtopolicycollection) | **POST** /api/policycollections/{code}/add | AddToPolicyCollection: Add To PolicyCollection
*PoliciesApi* | [**CreatePolicy**](docs/PoliciesApi.md#createpolicy) | **POST** /api/policies | CreatePolicy: Create Policy
*PoliciesApi* | [**CreatePolicyCollection**](docs/PoliciesApi.md#createpolicycollection) | **POST** /api/policycollections | CreatePolicyCollection: Create PolicyCollection
*PoliciesApi* | [**DeletePolicy**](docs/PoliciesApi.md#deletepolicy) | **DELETE** /api/policies/{code} | DeletePolicy: Delete Policy
*PoliciesApi* | [**DeletePolicyCollection**](docs/PoliciesApi.md#deletepolicycollection) | **DELETE** /api/policycollections/{code} | DeletePolicyCollection: Delete PolicyCollection
*PoliciesApi* | [**Evaluate**](docs/PoliciesApi.md#evaluate) | **POST** /api/me | Evaluate: Run one or more evaluations
*PoliciesApi* | [**GetOwnPolicies**](docs/PoliciesApi.md#getownpolicies) | **GET** /api/me | GetOwnPolicies: Get policies of requesting user
*PoliciesApi* | [**GetPolicy**](docs/PoliciesApi.md#getpolicy) | **GET** /api/policies/{code} | GetPolicy: Get Policy
*PoliciesApi* | [**GetPolicyCollection**](docs/PoliciesApi.md#getpolicycollection) | **GET** /api/policycollections/{code} | GetPolicyCollection: Get PolicyCollection
*PoliciesApi* | [**ListPolicies**](docs/PoliciesApi.md#listpolicies) | **GET** /api/policies | [EARLY ACCESS] ListPolicies: List Policies
*PoliciesApi* | [**ListPolicyCollections**](docs/PoliciesApi.md#listpolicycollections) | **GET** /api/policycollections | ListPolicyCollections: List PolicyCollections
*PoliciesApi* | [**PagePolicies**](docs/PoliciesApi.md#pagepolicies) | **GET** /api/policies/page | [EARLY ACCESS] PagePolicies: Page Policies
*PoliciesApi* | [**PagePolicyCollections**](docs/PoliciesApi.md#pagepolicycollections) | **GET** /api/policycollections/page | PagePolicyCollections: Page PolicyCollections
*PoliciesApi* | [**RemoveFromPolicyCollection**](docs/PoliciesApi.md#removefrompolicycollection) | **POST** /api/policycollections/{code}/remove | RemoveFromPolicyCollection: Remove From PolicyCollection
*PoliciesApi* | [**UpdatePolicy**](docs/PoliciesApi.md#updatepolicy) | **PUT** /api/policies/{code} | UpdatePolicy: Update Policy
*PoliciesApi* | [**UpdatePolicyCollection**](docs/PoliciesApi.md#updatepolicycollection) | **PUT** /api/policycollections/{code} | UpdatePolicyCollection: Update PolicyCollection
*PolicyTemplatesApi* | [**CreatePolicyTemplate**](docs/PolicyTemplatesApi.md#createpolicytemplate) | **POST** /api/policytemplates | [EXPERIMENTAL] CreatePolicyTemplate: Create a Policy Template
*PolicyTemplatesApi* | [**DeletePolicyTemplate**](docs/PolicyTemplatesApi.md#deletepolicytemplate) | **DELETE** /api/policytemplates/{code} | [EXPERIMENTAL] DeletePolicyTemplate: Deleting a policy template
*PolicyTemplatesApi* | [**GeneratePolicyFromTemplate**](docs/PolicyTemplatesApi.md#generatepolicyfromtemplate) | **POST** /api/policytemplates/$generatepolicy | [EXPERIMENTAL] GeneratePolicyFromTemplate: Generate policy from template
*PolicyTemplatesApi* | [**GetPolicyTemplate**](docs/PolicyTemplatesApi.md#getpolicytemplate) | **GET** /api/policytemplates/{code} | [EXPERIMENTAL] GetPolicyTemplate: Retrieving one Policy Template
*PolicyTemplatesApi* | [**ListPolicyTemplates**](docs/PolicyTemplatesApi.md#listpolicytemplates) | **GET** /api/policytemplates | [EXPERIMENTAL] ListPolicyTemplates: List Policy Templates
*PolicyTemplatesApi* | [**UpdatePolicyTemplate**](docs/PolicyTemplatesApi.md#updatepolicytemplate) | **PUT** /api/policytemplates/{code} | [EXPERIMENTAL] UpdatePolicyTemplate: Update a Policy Template
*RolesApi* | [**AddPolicyCollectionToRole**](docs/RolesApi.md#addpolicycollectiontorole) | **POST** /api/roles/{scope}/{code}/policycollections | AddPolicyCollectionToRole: Add policy collections to a role
*RolesApi* | [**CreateRole**](docs/RolesApi.md#createrole) | **POST** /api/roles | CreateRole: Create Role
*RolesApi* | [**DeleteRole**](docs/RolesApi.md#deleterole) | **DELETE** /api/roles/{code} | DeleteRole: Delete Role
*RolesApi* | [**GetRole**](docs/RolesApi.md#getrole) | **GET** /api/roles/{code} | GetRole: Get Role
*RolesApi* | [**ListRoles**](docs/RolesApi.md#listroles) | **GET** /api/roles | ListRoles: List Roles
*RolesApi* | [**RemovePolicyCollectionFromRole**](docs/RolesApi.md#removepolicycollectionfromrole) | **DELETE** /api/roles/{scope}/{code}/policycollections/{policycollectionscope}/{policycollectioncode} | RemovePolicyCollectionFromRole: Remove policy collection from role
*RolesApi* | [**UpdateRole**](docs/RolesApi.md#updaterole) | **PUT** /api/roles/{code} | UpdateRole: Update Role
*UserRolesApi* | [**AddPolicyCollectionToUserRole**](docs/UserRolesApi.md#addpolicycollectiontouserrole) | **POST** /api/userroles/{userid}/policycollections | AddPolicyCollectionToUserRole: Add a policy collection to a user-role
*UserRolesApi* | [**AddPolicyToUserRole**](docs/UserRolesApi.md#addpolicytouserrole) | **POST** /api/userroles/{userid}/policies | AddPolicyToUserRole: Add a policy to a user-role
*UserRolesApi* | [**CreateUserRole**](docs/UserRolesApi.md#createuserrole) | **POST** /api/userroles | CreateUserRole: Create a user-role
*UserRolesApi* | [**DeleteUserRole**](docs/UserRolesApi.md#deleteuserrole) | **DELETE** /api/userroles/{userid} | DeleteUserRole: Delete a user-role
*UserRolesApi* | [**GetUserRole**](docs/UserRolesApi.md#getuserrole) | **GET** /api/userroles/{userid} | GetUserRole: Get a user-role
*UserRolesApi* | [**ListUserRoles**](docs/UserRolesApi.md#listuserroles) | **GET** /api/userroles | ListUserRoles: List user-roles
*UserRolesApi* | [**RemovePolicyCollectionFromUserRole**](docs/UserRolesApi.md#removepolicycollectionfromuserrole) | **DELETE** /api/userroles/{userid}/policycollections/{policyCollectionScope}/{policyCollectionCode} | RemovePolicyCollectionFromUserRole: Remove a policy collection from a user-role
*UserRolesApi* | [**RemovePolicyFromUserRole**](docs/UserRolesApi.md#removepolicyfromuserrole) | **DELETE** /api/userroles/{userid}/policies/{policyScope}/{policyCode} | RemovePolicyFromUserRole: Remove a policy from a user-role
*UserRolesApi* | [**UpdateUserRole**](docs/UserRolesApi.md#updateuserrole) | **POST** /api/userroles/{userid}/update | UpdateUserRole: Update a user-role


<a id="documentation-for-models"></a>
## Documentation for Models

 - [AccessControlledAction](docs/AccessControlledAction.md)
 - [AccessControlledResource](docs/AccessControlledResource.md)
 - [ActionId](docs/ActionId.md)
 - [AddPolicyCollectionToRoleRequest](docs/AddPolicyCollectionToRoleRequest.md)
 - [AddPolicyToRoleRequest](docs/AddPolicyToRoleRequest.md)
 - [AddToPolicyCollectionRequest](docs/AddToPolicyCollectionRequest.md)
 - [AsAtPredicateContract](docs/AsAtPredicateContract.md)
 - [AsAtRangeForSpec](docs/AsAtRangeForSpec.md)
 - [AsAtRelative](docs/AsAtRelative.md)
 - [AttachedPolicyDefinitionResponse](docs/AttachedPolicyDefinitionResponse.md)
 - [DateQuality](docs/DateQuality.md)
 - [DateUnit](docs/DateUnit.md)
 - [EffectiveDateHasQuality](docs/EffectiveDateHasQuality.md)
 - [EffectiveDateRelative](docs/EffectiveDateRelative.md)
 - [EffectiveRange](docs/EffectiveRange.md)
 - [EntitlementMetadata](docs/EntitlementMetadata.md)
 - [EvaluationRequest](docs/EvaluationRequest.md)
 - [EvaluationResponse](docs/EvaluationResponse.md)
 - [EvaluationResult](docs/EvaluationResult.md)
 - [ForSpec](docs/ForSpec.md)
 - [GeneratePolicyFromTemplateRequest](docs/GeneratePolicyFromTemplateRequest.md)
 - [GeneratedPolicyComponents](docs/GeneratedPolicyComponents.md)
 - [Grant](docs/Grant.md)
 - [HowSpec](docs/HowSpec.md)
 - [IdSelectorDefinition](docs/IdSelectorDefinition.md)
 - [IdentifierPartSchema](docs/IdentifierPartSchema.md)
 - [IfExpression](docs/IfExpression.md)
 - [IfFeatureChainExpression](docs/IfFeatureChainExpression.md)
 - [IfIdentityClaimExpression](docs/IfIdentityClaimExpression.md)
 - [IfIdentityScopeExpression](docs/IfIdentityScopeExpression.md)
 - [IfRequestHeaderExpression](docs/IfRequestHeaderExpression.md)
 - [KeyValuePairOfStringToString](docs/KeyValuePairOfStringToString.md)
 - [Link](docs/Link.md)
 - [LusidProblemDetails](docs/LusidProblemDetails.md)
 - [LusidValidationProblemDetails](docs/LusidValidationProblemDetails.md)
 - [MatchAllSelectorDefinition](docs/MatchAllSelectorDefinition.md)
 - [MetadataExpression](docs/MetadataExpression.md)
 - [MetadataSelectorDefinition](docs/MetadataSelectorDefinition.md)
 - [NonTransitiveSupervisorRoleResource](docs/NonTransitiveSupervisorRoleResource.md)
 - [Operator](docs/Operator.md)
 - [PointInTimeSpecification](docs/PointInTimeSpecification.md)
 - [PolicyCollectionCreationRequest](docs/PolicyCollectionCreationRequest.md)
 - [PolicyCollectionId](docs/PolicyCollectionId.md)
 - [PolicyCollectionResponse](docs/PolicyCollectionResponse.md)
 - [PolicyCollectionUpdateRequest](docs/PolicyCollectionUpdateRequest.md)
 - [PolicyCreationRequest](docs/PolicyCreationRequest.md)
 - [PolicyId](docs/PolicyId.md)
 - [PolicyIdRoleResource](docs/PolicyIdRoleResource.md)
 - [PolicyResponse](docs/PolicyResponse.md)
 - [PolicySelectorDefinition](docs/PolicySelectorDefinition.md)
 - [PolicyTemplateCreationRequest](docs/PolicyTemplateCreationRequest.md)
 - [PolicyTemplateResponse](docs/PolicyTemplateResponse.md)
 - [PolicyTemplateUpdateRequest](docs/PolicyTemplateUpdateRequest.md)
 - [PolicyTemplatedSelector](docs/PolicyTemplatedSelector.md)
 - [PolicyType](docs/PolicyType.md)
 - [PolicyUpdateRequest](docs/PolicyUpdateRequest.md)
 - [RelativeToDateTime](docs/RelativeToDateTime.md)
 - [RemoveFromPolicyCollectionRequest](docs/RemoveFromPolicyCollectionRequest.md)
 - [RequestDetails](docs/RequestDetails.md)
 - [RequestedActionKey](docs/RequestedActionKey.md)
 - [ResourceDetails](docs/ResourceDetails.md)
 - [ResourceListOfAccessControlledResource](docs/ResourceListOfAccessControlledResource.md)
 - [ResourceListOfPolicyCollectionResponse](docs/ResourceListOfPolicyCollectionResponse.md)
 - [ResourceListOfPolicyResponse](docs/ResourceListOfPolicyResponse.md)
 - [ResourceListOfPolicyTemplateResponse](docs/ResourceListOfPolicyTemplateResponse.md)
 - [ResourceListOfUserRoleResponse](docs/ResourceListOfUserRoleResponse.md)
 - [RoleCreationRequest](docs/RoleCreationRequest.md)
 - [RoleId](docs/RoleId.md)
 - [RoleResourceRequest](docs/RoleResourceRequest.md)
 - [RoleResponse](docs/RoleResponse.md)
 - [RoleUpdateRequest](docs/RoleUpdateRequest.md)
 - [SelectorDefinition](docs/SelectorDefinition.md)
 - [TemplateMetadata](docs/TemplateMetadata.md)
 - [TemplateSelection](docs/TemplateSelection.md)
 - [TextOperator](docs/TextOperator.md)
 - [UserRoleCreationRequest](docs/UserRoleCreationRequest.md)
 - [UserRoleResponse](docs/UserRoleResponse.md)
 - [UserRoleUpdateRequest](docs/UserRoleUpdateRequest.md)
 - [WhenSpec](docs/WhenSpec.md)

