FROM mcr.microsoft.com/dotnet/aspnet:5.0
COPY src/GitHubPackageDemo.WebApp/bin/publish/ ./app
WORKDIR /app
ENTRYPOINT ["dotnet", "GitHubPackageDemo.WebApp.dll"]