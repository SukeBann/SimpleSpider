FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["SimpleSpiderGUI/SimpleSpiderGUI.csproj", "SimpleSpiderGUI/"]
RUN dotnet restore "SimpleSpiderGUI/SimpleSpiderGUI.csproj"
COPY . .
WORKDIR "/src/SimpleSpiderGUI"
RUN dotnet build "SimpleSpiderGUI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SimpleSpiderGUI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SimpleSpiderGUI.dll"]
