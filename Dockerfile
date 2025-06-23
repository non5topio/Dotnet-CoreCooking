FROM mcr.microsoft.com/dotnet/sdk:5.0 AS test

WORKDIR /app

# Copy solution and project files
COPY *.sln ./
COPY CoreCooking.Models/*.csproj ./CoreCooking.Models/
COPY CoreCooking.API/*.csproj ./CoreCooking.API/
COPY CoreCooking.Website/*.csproj ./CoreCooking.Website/
COPY CoreCooking.Domain/*.csproj ./CoreCooking.Domain/
COPY CoreCooking.Tests/*.csproj ./CoreCooking.Tests/

# Restore dependencies
RUN dotnet restore

# Copy the rest of the code
COPY . .

# Install ReportGenerator tool
RUN dotnet tool install -g dotnet-reportgenerator-globaltool

# Add dotnet tools to PATH
ENV PATH="${PATH}:/root/.dotnet/tools"

# Run tests with coverage
#CMD ["dotnet", "test"] 
CMD ["bash", "-c", "echo GLIBC VERSION && ldd --version && echo GLIBC VERSION CHECK && dotnet test"]
