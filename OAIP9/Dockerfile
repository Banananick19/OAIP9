FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["OAIP9/OAIP9.csproj", "OAIP9/"]
RUN dotnet restore "OAIP9/OAIP9.csproj"
COPY . .
WORKDIR "/src/OAIP9"
RUN dotnet build "OAIP9.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OAIP9.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OAIP9.dll"]
