FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /app

# Copia o projeto e restaura as dependencias
COPY *.sln .
COPY DemoAspNetCore.Web/*.csproj ./DemoAspNetCore.Web/
RUN dotnet restore

# Copia o restante do projeto e realiza o build / publish
COPY DemoAspNetCore.Web/. ./DemoAspNetCore.Web/
WORKDIR /app/DemoAspNetCore.Web
RUN dotnet publish -c Release -o out

FROM microsoft/dotnet:2.1-aspnetcore-runtime AS runtime
WORKDIR /app
COPY --from=build /app/DemoAspNetCore.Web/out ./
ENTRYPOINT ["dotnet", "DemoAspNetCore.Web.dll"]