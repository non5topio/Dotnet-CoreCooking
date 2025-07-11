FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS test

WORKDIR /app

# Copy everything first to avoid case sensitivity and missing file issues
COPY . .

# Restore dependencies
RUN dotnet restore

# Install ReportGenerator tool for coverage reports (compatible version for .NET 5.0)
RUN dotnet tool install -g dotnet-reportgenerator-globaltool --version 4.8.12

# Add dotnet tools to PATH
ENV PATH="${PATH}:/root/.dotnet/tools"

# Configure test command to generate coverage report
CMD ["bash", "-c", "echo GLIBC VERSION && ldd --version && echo GLIBC VERSION CHECK && dotnet test --collect:'XPlat Code Coverage' --results-directory ./CoreCooking.Tests/TestResults/ --logger trx && reportgenerator -reports:./CoreCooking.Tests/TestResults/**/coverage.cobertura.xml -targetdir:./CoreCooking.Tests/TestResults/ -reporttypes:Cobertura"]