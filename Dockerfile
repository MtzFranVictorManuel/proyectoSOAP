FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["facturaServicio/facturaServicio.csproj", "facturaServicio/"]
RUN dotnet restore "facturaServicio/facturaServicio.csproj"
COPY . .
WORKDIR "/src/facturaServicio"
RUN dotnet build "facturaServicio.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "facturaServicio.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "facturaServicio.dll"]