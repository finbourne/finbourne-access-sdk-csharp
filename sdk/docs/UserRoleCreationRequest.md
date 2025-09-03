# Finbourne.Access.Sdk.Model.UserRoleCreationRequest
Dto used to request creating a user's role

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserId** | **string** | The Id of the user for whom to create the role. | 
**Resource** | [**PolicyIdRoleResource**](PolicyIdRoleResource.md) |  | 

```csharp
using Finbourne.Access.Sdk.Model;
using System;

string userId = "userId";
PolicyIdRoleResource resource = new PolicyIdRoleResource();

UserRoleCreationRequest userRoleCreationRequestInstance = new UserRoleCreationRequest(
    userId: userId,
    resource: resource);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
