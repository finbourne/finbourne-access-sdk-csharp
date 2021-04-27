![LUSID_by_Finbourne](https://content.finbourne.com/LUSID_repo.png)

| branch | status |
| --- | --- |
| `master` |  ![Nuget](https://img.shields.io/nuget/v/Finbourne.Access.Sdk?color=blue)

# FINBOURNE Access C# SDK

The NuGet package for the LUSID SDK can installed from https://www.nuget.org/packages/Finbourne.Access.Sdk using the following:

```
$ dotnet add package Finbourne.Access.Sdk
```

## Publishing

The SDK can be published to a NuGet repository using the following script located in the root of the repo:

```
$ publish <API key> <repo url>
```

for example to publish to nuget.org

```
$ publish <API key> https://nuget.org
```