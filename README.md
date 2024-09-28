# MarocMarketplace

**MarocMarketplace** is een webshop die wordt ontwikkeld met .NET Core voor de backend, een REST API voor communicatie, SQL Server voor dataopslag en React voor de frontend. Dit project is momenteel nog in ontwikkeling.

## Functionaliteiten

- **Gebruikersregistratie en -authenticatie**: Klanten kunnen zich registreren en inloggen op de webshop.
- **Productbeheer**: Administrators kunnen producten toevoegen, bijwerken en verwijderen.
- **Productweergave**: Klanten kunnen producten bekijken en doorzoeken via een dynamische interface.
- **Winkelmandje**: Klanten kunnen producten toevoegen aan hun winkelmandje en een bestelling plaatsen.
- **Bestelgeschiedenis**: Klanten kunnen hun eerdere bestellingen bekijken.

## Technologieën

- **Backend**: .NET Core
  - REST API voor communicatie tussen frontend en backend.
  - SQL Server voor het beheren van product-, klant- en bestellingsgegevens.
  
- **Frontend**: React
  - Dynamische gebruikersinterface met component-gebaseerde architectuur.
  - Responsive design voor zowel desktop als mobiel.

- **IDE**: Visual Studio 2022

## Installatie

1. **Clone de repository**:
    ```bash
    git clone https://github.com/Naamari1/MarocMarketplace.git
    cd MarocMarketplace
    ```

2. **Backend (ASP.NET Core)**:
   - Open het project in **Visual Studio 2022**.
   - Zorg ervoor dat de juiste SQL Server-verbinding is ingesteld in het `appsettings.json` bestand.
   - Voer de Entity Framework migraties uit om de database te initialiseren:
     ```bash
     dotnet ef database update
     ```
   - Start de API vanuit Visual Studio door de oplossing te builden en uit te voeren.

3. **Frontend (React)**:
   - Navigeer naar de `ClientApp` map:
     ```bash
     cd ClientApp
     ```
   - Installeer de afhankelijkheden:
     ```bash
     npm install
     ```
   - Start de frontend server:
     ```bash
     npm start
     ```

4. **Open de applicatie**:
   - Backend draait op `http://localhost:5000`
   - Frontend draait op `http://localhost:3000`

## API Endpoints

Enkele belangrijke API endpoints:

- `GET /api/products`: Haalt de lijst van producten op.
- `GET /api/products/{id}`: Haalt de details van een specifiek product op.
- `POST /api/products`: Maakt een nieuw product aan (alleen toegankelijk voor admins).
- `PUT /api/products/{id}`: Update een product (alleen toegankelijk voor admins).
- `DELETE /api/products/{id}`: Verwijdert een product (alleen toegankelijk voor admins).

## Roadmap

- [ ] Voltooiing van gebruikersregistratie en authenticatie.
- [ ] Betaalfunctie implementeren.
- [ ] Productbeoordelingen en recensies toevoegen.
- [ ] Uitgebreide zoek- en filteropties voor producten toevoegen.
- [ ] Integratie van een derde partij voor verzending en tracking.

## Bijdragen

Bijdragen aan dit project zijn welkom! Voel je vrij om een pull request in te dienen of issues aan te maken voor eventuele bugs of suggesties.

## Contact

Neem gerust contact op als je vragen hebt:

- **Naam**: Nouri Aamari
- **Email**: aamarinouri@gmail.com
- **GitHub**: [Naamari1](https://github.com/Naamari1)

---

*Dit project is momenteel in ontwikkeling en kan bugs of onvolledige functionaliteiten bevatten.*

