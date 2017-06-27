# nuget-dependencies-of-netstandard-library-bug
This repository reproduces a bug with classic .NET application that references .NET Standard library with NuGet dependencies

# Current state of this issue
You can monitor it in https://github.com/NuGet/Home/issues/4488. It will not be fixed earlier than NuGet 4.4.

# Workaround
A workaround is to add `<RestoreProjectStyle>PackageReference</RestoreProjectStyle>` to a legacy project (`ClassicConsoleApp` in this case). See workaround commit: 89162e50ddd5f455e167badd6e38b115d3a3e316. 
