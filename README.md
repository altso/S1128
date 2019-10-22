# S1128
A sample repo to demonstrate false positive on S1128 in `SonarAnalyzer.CSharp` `8.0.0.9566`.
See https://github.com/SonarSource/sonar-dotnet/issues/2747 for more details.


## Steps to reproduce

```
C:\Projects\S1128> dotnet build
Microsoft (R) Build Engine version 16.3.0+0f4c62fea for .NET Core
Copyright (C) Microsoft Corporation. All rights reserved.

  Restore completed in 133.06 ms for C:\Projects\S1128\S1128.csproj.
Sample.cs(3,1): warning S1128: Remove this unnecessary 'using'. [C:\Projects\S1128\S1128.csproj]
  S1128 -> C:\Projects\S1128\bin\Debug\netstandard2.0\S1128.dll

Build succeeded.

Sample.cs(3,1): warning S1128: Remove this unnecessary 'using'. [C:\Projects\S1128\S1128.csproj]
    1 Warning(s)
    0 Error(s)

Time Elapsed 00:00:03.03
```
