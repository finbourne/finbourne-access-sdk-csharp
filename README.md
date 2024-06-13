![LUSID_by_Finbourne](./resources/Finbourne_Logo_Teal.svg)

| branch | status |
| --- | --- |
| `master` |  ![Nuget](https://img.shields.io/nuget/v/Finbourne.Access.Sdk?color=blue)

# FOR VERSIONS AFTER v0.0.1105
The latest C# SDK (Preview) supporting `Production`, `Early Access`, `Beta` and `Experimental` API endpoints has moved to https://github.com/finbourne/access-sdk-csharp-preview with the NuGet package available from https://www.nuget.org/packages/Finbourne.Access.Sdk.Preview/.

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
