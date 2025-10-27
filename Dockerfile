FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS test

WORKDIR /app

# Copy everything first to avoid case sensitivity and missing file issues
COPY . .

# Restore dependencies
RUN dotnet restore

# Add coverlet.msbuild for more reliable code coverage
RUN dotnet add CoreCooking.Tests/CoreCooking.Tests.csproj package coverlet.msbuild

# Install ReportGenerator tool for coverage reports (compatible version for .NET 5.0)
RUN dotnet tool install -g dotnet-reportgenerator-globaltool --version 4.8.12

# Add dotnet tools to PATH
ENV PATH="${PATH}:/root/.dotnet/tools"

# Configure test command to run only IngredientParserTests with coverage report
CMD ["bash", "-c", "echo GLIBC VERSION && ldd --version && echo GLIBC VERSION CHECK && dotnet test CoreCooking.Tests/CoreCooking.Tests.csproj --filter FullyQualifiedName~CoreCooking.Parsers.IngredientParserTests /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura /p:CoverletOutput=./TestResults/coverage.cobertura.xml && echo '=== Coverage Report Generated ===' && find ./CoreCooking.Tests/TestResults/ -name '*.xml' && reportgenerator -reports:./CoreCooking.Tests/TestResults/coverage.cobertura.xml -targetdir:./CoreCooking.Tests/TestResults/CoverageReport -reporttypes:'Html;Cobertura' && echo '=== HTML Coverage Report Location ===' && ls -la ./CoreCooking.Tests/TestResults/CoverageReport/"]