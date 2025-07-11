FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS test

WORKDIR /app

# Copy solution file first
COPY *.sln ./

# Copy project files (only copy what exists)
COPY CoreCooking.Models/*.csproj ./CoreCooking.Models/
COPY CoreCooking.API/*.csproj ./CoreCooking.API/
COPY CoreCooking.Website/*.csproj ./CoreCooking.Website/
COPY CoreCooking.Domain/*.csproj ./CoreCooking.Domain/
COPY CoreCooking.Tests/*.csproj ./CoreCooking.Tests/

# Restore dependencies
RUN dotnet restore

# Copy the rest of the code
COPY . .

# Install ReportGenerator tool for coverage reports
RUN dotnet tool install -g dotnet-reportgenerator-globaltool

# Add dotnet tools to PATH
ENV PATH="${PATH}:/root/.dotnet/tools"

# Configure test command to generate coverage report
CMD ["bash", "-c", "echo GLIBC VERSION && ldd --version && echo GLIBC VERSION CHECK && dotnet test --collect:'XPlat Code Coverage' --results-directory ./CoreCooking.Tests/TestResults/ --logger trx && reportgenerator -reports:./CoreCooking.Tests/TestResults/**/coverage.cobertura.xml -targetdir:./CoreCooking.Tests/TestResults/ -reporttypes:Cobertura"]