# URL Shortener

## ENG

### 🚀 Description

This is a simple URL shortening service built with **C#** and **ASP.NET Core**. The project allows users to shorten URLs and access them via short codes. It uses **Entity Framework Core** for database management and **Swagger** for API documentation.

### 🔧 Getting Started

#### Prerequisites

Before running the project, make sure you have the following installed:

- [.NET 6+ SDK](https://dotnet.microsoft.com/download/dotnet)
- [PostgreSQL](https://www.postgresql.org/download/)
- A text editor such as [Visual Studio Code](https://code.visualstudio.com/) or [Visual Studio](https://visualstudio.microsoft.com/)

#### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/tolgaozt/url_shortener.git
   ```

2. Navigate to the project folder:

   ```bash
   cd UrlShortener
   ```

3. Restore the dependencies:

   ```bash
   dotnet restore
   ```

4. Set up the PostgreSQL database (make sure you have a PostgreSQL instance running):

   Update the `appsettings.json` file with your PostgreSQL connection string.

5. Run the migrations:

   ```bash
   dotnet ef database update
   ```

6. Run the application:

   ```bash
   dotnet run
   ```

7. Access the Swagger interface at:

   ```
   http://localhost:5000/swagger
   ```

### 🚀 Features

- **Shorten URLs**: Create short URLs from long URLs.
- **Redirect Short URLs**: Access the original URL by visiting the short code.
- **Swagger API**: A fully documented API using Swagger.
- **PostgreSQL Database**: Stores URL mappings in a PostgreSQL database.

### 📈 Future Enhancements

- **Click statistics**: Track how many times a shortened URL is clicked.
- **Custom short codes**: Allow users to create custom short URLs.
- **Expiration of links**: Automatically expire shortened URLs after a certain period.
- **Admin Dashboard**: Create an admin dashboard in React or Vue for URL management.

### 🧑‍💻 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

### 🤝 Acknowledgements

- [ASP.NET Core](https://dotnet.microsoft.com/apps/aspnet)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
- [Swagger](https://swagger.io/)
- [PostgreSQL](https://www.postgresql.org/)

---

## FR

### 🚀 Description

Il s'agit d'un service simple de raccourcissement d'URL construit avec **C#** et **ASP.NET Core**. Le projet permet aux utilisateurs de raccourcir des URL et d'y accéder via des codes courts. Il utilise **Entity Framework Core** pour la gestion de la base de données et **Swagger** pour la documentation de l'API.

### 🔧 Démarrage

#### Prérequis

Avant d'exécuter le projet, assurez-vous d'avoir installé les éléments suivants :

- [SDK .NET 6+](https://dotnet.microsoft.com/download/dotnet)
- [PostgreSQL](https://www.postgresql.org/download/)
- Un éditeur de texte comme [Visual Studio Code](https://code.visualstudio.com/) ou [Visual Studio](https://visualstudio.microsoft.com/)

#### Installation

1. Clonez le dépôt :

   ```bash
   git clone https://github.com/tolgaozt/url_shortener.git
   ```

2. Allez dans le dossier du projet :

   ```bash
   cd UrlShortener
   ```

3. Restaurez les dépendances :

   ```bash
   dotnet restore
   ```

4. Configurez la base de données PostgreSQL (assurez-vous d'avoir une instance PostgreSQL en fonctionnement) :

   Mettez à jour le fichier `appsettings.json` avec votre chaîne de connexion PostgreSQL.

5. Exécutez les migrations :

   ```bash
   dotnet ef database update
   ```

6. Lancez l'application :

   ```bash
   dotnet run
   ```

7. Accédez à l'interface Swagger à l'adresse suivante :

   ```
   http://localhost:5000/swagger
   ```

### 🚀 Fonctionnalités

- **Raccourcir des URL** : Créez des URL courtes à partir d'URL longues.
- **Redirection des URL courtes** : Accédez à l'URL originale en visitant le code court.
- **API Swagger** : Une API entièrement documentée avec Swagger.
- **Base de données PostgreSQL** : Stocke les correspondances d'URL dans une base de données PostgreSQL.

### 📈 Améliorations futures

- **Statistiques de clics** : Suivi du nombre de fois où une URL raccourcie a été cliquée.
- **Codes courts personnalisés** : Permettre aux utilisateurs de créer des URL courtes personnalisées.
- **Expiration des liens** : Expiration automatique des URL raccourcies après une certaine période.
- **Dashboard admin** : Créer un tableau de bord admin en React ou Vue pour la gestion des URL.

### 🧑‍💻 Licence

Ce projet est sous licence MIT - consultez le fichier [LICENSE](LICENSE) pour plus de détails.

### 🤝 Remerciements

- [ASP.NET Core](https://dotnet.microsoft.com/apps/aspnet)
- [Entity Framework Core](https://docs.microsoft.com/fr-fr/ef/core/)
- [Swagger](https://swagger.io/)
- [PostgreSQL](https://www.postgresql.org/)
