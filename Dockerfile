# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copy everything and restore dependencies
COPY . .
RUN dotnet restore HotelsApi/HotelsAPI.sln

# Build the solution (Release mode)
RUN dotnet build HotelsApi/HotelsAPI.csproj -c Release -o /app/build

# Optional: Run unit tests
# RUN dotnet test UnitTest/UnitTest.csproj --no-build --verbosity normal


# Publish the Web API project
RUN dotnet publish HotelsApi/HotelsAPI.csproj -c Release -o /app/publish

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

# Expose port (assuming your app listens on 5000)
EXPOSE 80
ENTRYPOINT ["dotnet", "HotelsAPI.dll"]