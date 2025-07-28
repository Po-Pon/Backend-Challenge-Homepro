# Getting Started

#### 1. Clone the Repository

```
git clone <YOUR_REPOSITORY_URL>
cd <PROJECT_FOLDER_NAME>
```

#### 2. Configure Your Database Connection
  The project requires a connection to a SQL Server database. You need to create a local configuration file to store your connection string.
In the main project directory, create a new file named appsettings.Development.json.
Copy the structure from appsettings.json and add your actual database connection string. The content of your appsettings.Development.json should look like this:
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER_ADDRESS;Database=BookShopDb;User Id=YOUR_USERNAME;Password=YOUR_PASSWORD;TrustServerCertificate=True;"
  }
}
```
#### 3. Restore Dependencies

```
dotnet restore
```
#### 4. Apply Database Migrations

```
dotnet ef database update
```
#### Running the Application
  Once the setup is complete, you can run the application with the following command:
```
dotnet run
```
The API will start, and you can access it at the URLs provided in the terminal output (e.g., https://localhost:7123).

#### Using the API
You can explore and test all the available endpoints using the Swagger UI. Navigate to the /swagger endpoint in your browser.
```
Example: https://localhost:7123/swagger
```
### API Endpoints
* POST /api/auth/register: Register a new user.

* POST /api/auth/login: Log in to receive a User Id.

* GET /api/books: Get a list of books, sorted by title.

* POST /api/user/like: Like a book.
