# Custom code generator that works with dotnet aspnet-codegenerator

### Steps to build. 
1. Run `dotnet restore` in the `src\CustomScaffolder\` directory.
2. Run `dotnet pack -o ..\artifacts --version-suffix dev-1` in the `src\CustomScaffolder\` directory.
3. Run `dotnet restore` in the `SampleTestApp` directory.
4. Run `dotnet aspnet-codegenerator -p . sample --model SampleModel` in the `SampleTestApp` directory.


### Requirements
1. dotnet cli version 1.0.0-preview2-003133

### Sample executions

```
C:\git\CustomScaffolder\SampleTestApp>dotnet aspnet-codegenerator -p . sample -h
Finding the generator 'sample'...
Running the generator 'sample'...
Usage:  sample [options]
Options:
  --help|-h|-?  Show help information
  --model|-m
RunTime 00:00:03.69
```

```
C:\git\CustomScaffolder\SampleTestApp>dotnet aspnet-codegenerator -p . sample -m SampleModel
Finding the generator 'sample'...
Running the generator 'sample'...
Model name: SampleModel
RunTime 00:00:01.57
```