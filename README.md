# bug-vsglobs
A repository demonstrating a Visual Studio bug using ProjectReferences with glob patterns

## dotnet 

Everything works as expected on the command line and older versions of Visual Studio

## Visual Studio

Both building and running in Visual Studio fails with build errors. 

The Project references are also not displayed under Dependencies.

## Tested Versions

* ✔️ dotnet 8.0.205
* ✔️ dotnet 8.0.300
* ✔️ Visual Studio 2022 Version 17.9.7
* ❌ Visual Studio 2022 Version 17.10.0
* ❌ Visual Studio 2022 Preview Version 17.11.0 Preview 1.0
