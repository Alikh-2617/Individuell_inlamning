# Individuell examination CI/CD

Målet med denna uppgift är att skapa och implementera en fullständig CI/CD-kedja för ett API-projekt i C# med fokus på kryptering och avkryptering. För att uppnå detta ska Git Flow och GitHub Actions användas. Slutligen kommer API:et att publiceras och distribueras till AWS Elastic Beanstalk som en del av en kontinuerlig integrering och kontinuerlig leverans (CI/CD)-process.

-- Clone projekt (Github Repo)

    git clone https://github.com/Alikh-2617/WebApplication03.git


-- Docker image (Docker hub)
-- För att få imagen :

    docker pull alikhavari2617/Individuell_inlamning:latest


-- API

    API:et ska ha minst två endpoints (kan läggas till under utvecklingen ). En för att kryptera och en för att avkryptera. Krypteringsmedtod får du bestämma själv och behöver inte vara säker. ( ex: rövarspråket, caesar-chiffer).

-- Github

    Git och github användas under hela projektet och all kod skrivs i branches och mergas med hjälp av pull requests.

-- Publicering & build
   Api:et publiceras på AWS elastic beanstalk med hjällp av Github Actions.

    dotnet restore
    dotnet build
    dotnet run

-- Enhetstest (Xunit)
   Ytterligare funktionalitet utföras med hjälp av Github Actions. tex enhetstest

    cd ./XunitTest
    dotnet test


-- CI/CD proces skiss i Figma 
- Skissen beskriver CI/CD processen för både backend och frontend till appen. (Frontend behöver inte implementeras). Visualisera hur  
  och när koden går igenom olika steg i CI/CD-kedjan, inklusive bygge, testning och distribution.
  Länk : 
  
    https://www.figma.com/file/H5fgtvrB0GaJcYuup8asmP/Individuell-examination-CI%2FCD?type=whiteboard&node-id=0-1&t=ufFLGdHzdHbnv6fi-0


-- Copy Right

    Uppdatera koden baserat på dina tänkar (om du vill)