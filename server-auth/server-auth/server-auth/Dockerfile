FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["server-auth/server-auth.csproj", "server-auth/"]
RUN dotnet restore "server-auth/server-auth.csproj"
COPY . .
WORKDIR "/src/server-auth"
RUN dotnet build "server-auth.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "server-auth.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "server-auth.dll"]
