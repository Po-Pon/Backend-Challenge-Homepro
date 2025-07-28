Getting Started
Follow these steps to get the project up and running on your local machine.

1. Clone the Repository
Clone this repository to your local machine using your preferred method (HTTPS or SSH).

git clone <YOUR_REPOSITORY_URL>
cd <PROJECT_FOLDER_NAME>

2. Configure Your Database Connection
The project requires a connection to a SQL Server database. You need to create a local configuration file to store your connection string.

In the main project directory, create a new file named appsettings.Development.json.

Copy the structure from appsettings.json and add your actual database connection string. The content of your appsettings.Development.json should look like this:

{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER_ADDRESS;Database=BookShopDb;User Id=YOUR_USERNAME;Password=YOUR_PASSWORD;TrustServerCertificate=True;"
  }
}

Example for SQL Server Express on local machine:
"Server=.\\SQLEXPRESS;Database=BookShopDb;Trusted_Connection=True;TrustServerCertificate=True;"

Note: This file is listed in .gitignore and will not be committed to the repository, keeping your local database credentials secure.

3. Restore Dependencies
Navigate to the project's root directory in your terminal and run the following command to restore all the necessary NuGet packages.

dotnet restore

4. Apply Database Migrations
This command will create the database and the necessary tables based on the models defined in the code.

dotnet ef database update

Running the Application
Once the setup is complete, you can run the application with the following command:

dotnet run

The API will start, and you can access it at the URLs provided in the terminal output (e.g., https://localhost:7123).

Using the API
You can explore and test all the available endpoints using the Swagger UI. Navigate to the /swagger endpoint in your browser.

Example: https://localhost:7123/swagger

API Endpoints
POST /api/auth/register: Register a new user.

POST /api/auth/login: Log in to receive a JWT token.

GET /api/books: Get a list of books, sorted by title.

POST /api/user/like: Like a book.
