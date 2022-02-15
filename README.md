# GameDev


- [GameDev](#gamedev)
  - [Project details](#project-details)
    - [Technical](#technical)
    - [Dependencies](#dependencies)
  - [Testing](#testing)
    - [Coverage](#coverage)

## Project details

2D game (side scroll), with linear map, with linear map defined by 0 and 1, where:

- 0 the floor
- 1 jumping object

Example: `00010001001010`

### Technical

- Language: C#
- Framework: .NET 5.0
- Environment used for development and testing:
  - Platform: Mac (M1)
  - OS: macOS Monterey (12.1)

### Dependencies

Use the command below to list all the libraries used in the solution:

```sh
dotnet list package
```

Output:

![command used to list all packages](doc/img/dotnet-list-packages.png)

## Testing

Execute the command below to run all tests:

```sh
dotnet test
```

### Coverage

Before execute the steps below, needs to install the report generator:

```sh
dotnet tool install -g dotnet-reportgenerator-globaltool
```

Now, generate run all tests and collect the coverage data:
 
```sh
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura
```

Finally, generate the HTML coverage report:

```sh
reportgenerator \
-reports:"$PWD/ExampleTests/coverage.cobertura.xml" \
-targetdir:"coveragereport" \
-reporttypes:html
```

Output:

![commands used to generate the coverage report](doc/img/dotnet-test-coverage.gif)

> For more details about how to generate test coverage report, access the official Microsoft [documentation](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-code-coverage?tabs=linux).