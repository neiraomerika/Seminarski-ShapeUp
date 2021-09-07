FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["ShapeUp/ShapeUp.csproj", "ShapeUp/"]
RUN dotnet restore "ShapeUp/ShapeUp.csproj"
COPY . .
WORKDIR "/src/ShapeUp"
RUN dotnet build "ShapeUp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ShapeUp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ShapeUp.dll"]