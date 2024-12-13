# Gym DB Management

Gym DB Management is a Windows Forms application designed to streamline the management of gym operations. This project uses C#, Entity Framework, and SQL Server to handle tasks such as managing memberships, trainers, clients, subscriptions, and payment systems. The application also includes a survey system for recommending personalized memberships and a bonus program to improve customer retention.

## Features

- **Administrative Panel**: Manage clients, trainers, administrators, and their associated data.
- **Memberships and Subscriptions**: Create and manage gym memberships, subscriptions, and bonus programs.
- **Survey System**: Recommend memberships based on survey results.
- **Payment Management**: Track and process payments efficiently.
- **Entity Framework Integration**: Simplified database management with EF Core.

## Technologies Used

- **Programming Language**: C#
- **Framework**: Windows Forms
- **Database**: SQL Server
- **ORM**: Entity Framework Core

## Installation

### Prerequisites

- .NET Framework/SDK installed
- SQL Server installed and configured
- Visual Studio (recommended)

### Steps

1. Clone the repository:
   ```bash
   git clone https://github.com/stkossman/Gym-DB-Management.git
   ```

2. Open the solution file (`Gym-DB-Management.sln`) in Visual Studio.

3. Restore NuGet packages:
   ```bash
   dotnet restore
   ```

4. Update the database connection string in `appsettings.json` or directly in the code:
   ```json
   "ConnectionStrings": {
       "DefaultConnection": "Server=YOUR_SERVER;Database=GymDB;Trusted_Connection=True;"
   }
   ```

5. Apply database migrations:
   ```bash
   dotnet ef database update
   ```

6. Run the application:
   ```bash
   dotnet run
   ```

## Usage

1. **Login**: Use the admin credentials to log in to the application.
2. **Manage Data**: Navigate to the administrative panel to manage trainers, clients, and memberships.
3. **Run Surveys**: Use the survey feature to recommend the best membership options to clients.
4. **Monitor Payments**: Track and process payment transactions.

## Contributing

Contributions are welcome! Please follow these steps:

1. Fork the repository.
2. Create a new branch for your feature:
   ```bash
   git checkout -b feature-name
   ```
3. Commit your changes:
   ```bash
   git commit -m "Add feature description"
   ```
4. Push to your branch:
   ```bash
   git push origin feature-name
   ```
5. Open a pull request.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
