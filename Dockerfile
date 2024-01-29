# Byggsteg
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app
ADD ../Individuell_inlamning/ .
RUN dotnet restore
RUN dotnet publish -c Release -o out

# Publiceringssteg
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-env /app/out .
CMD ["dotnet", "Individuell_inlamning.dll"]