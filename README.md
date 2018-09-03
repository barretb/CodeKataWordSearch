## Word Search Code Kata for Pillar Technology
##### https://github.com/PillarTechnology/kata-word-search

#### Solution Author: Barret Blake

### Instructions:
This is a C# .NET Core v2.1 console application solution. It must be opened on a computer with Visual Studio 2017 or better and .NET Core 2.1 or better installed.

#### Build and Run in Visual Studio 2017 (easiest):
1. Open Solution in Visual Studio
2. Press Ctrl+Shift+B to build solution (or select Build Solution from the Build menu). Wait for solution to build
3. Press Ctrl+R, Ctrl+A to run unit tests in MSTest
4. Press Ctrl+F5 to execute applicatin

#### Build and Run From Command Prompt (less easy):
1. Open Visual Studio 2017 Developer Command Prompt
2. Navigate to solution base folder (folder containing CodeKataWordSearch.sln file)
3. Execute command: "dotnet build". Wait for solution to build
4. Navigate to subdirectory CodeKataWordSearchTest
5. Execute command: "dotnet test" to execute unit tests
6. Navigate back to base solution directory, then to sub-directory: /CodeKataWordSearch/bin/debug/netcoreapp2.1/
7. Execute command: "dotnet CodeKataWordSearch.dll testdata1.txt" to run application
8. To test any other test data file, copy the text file into the same directory as the .dll file and execute the command in step 7, replacing "testdata1.txt" with the name of the other test file

