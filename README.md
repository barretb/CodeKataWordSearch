## Word Search Code Kata for Pillar Technology
##### https://github.com/PillarTechnology/kata-word-search

#### Solution Author: Barret Blake

### Instructions:
This is a C# .NET Core v2.1 solution. It must be opened on a machine with Visual Studio 2017 or better and .NET Core 2.1 or better installed.

#### Build In Visual Studio 2017 (easiest):
1. Open Solution in Visual Studio
2. Press Ctrl+Shift+B to build solution (or select Build Solution from the Build menu). Wait for solution to build
3. Press Ctrl+R, Ctrl+A to run unit tests in MSTest
4. Press Ctrl+F5 to execute applicatin

#### Build and run from command prompt (less easy):
1. Open Visual Studio 2017 Developer Command Prompt
2. Navigate to solution base folder (folder containing PillarKataWordSearch.sln file)
3. Execute command: "dotnet build". Wait for solution to build
4. Navigate to subdirectory PillarKataWordSearchTest
5. Execute command: "dotnet test" to execute unit tests
6. Navigate back to base solution directory, then to sub-directory: /PillarKataWordSearch/bin/debug/netcoreapp2.1/
7. Execute command: "dotnet PillarKataWordSearch.dll testdata1.txt" to run application

