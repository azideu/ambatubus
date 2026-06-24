# Ambatubus transit system

Ambatubus is a bus ticketing and schedule management application built with Visual Basic .NET and Windows Forms. It uses a custom dark theme and SQL Server to manage schedules and passenger bookings.

## Dark emerald and charcoal design
The interface is customized for dark mode:
* Theme colors: Deep charcoal backgrounds (RGB 25, 30, 28), slate green borders (RGB 100, 120, 110), and mint emerald accents (RGB 20, 150, 85).
* Seating chart: A 2-1-2 bus seat layout with color coded buttons. Available seats are green, booked seats are disabled grey, and the selected seat is yellow.
* Interactive elements: Buttons change color when hovered.
* Grid tables: Dark cells with alternating row backgrounds and green selection highlights.

## Key features
* Seat maps: Loads seat states dynamically based on selected schedule bookings.
* Admin controls: Create, read, update, and delete schedules. Origin and destination are selected from dropdown menus of Malaysian cities.
* Security: Admin passwords are encrypted with SHA-256.
* Data integrity: SQL constraints prevent double booking the same seat on a trip.
* Receipts: Exports plain text receipts (.txt) directly to the Documents folder.

## Admin credentials
Access the admin panel using:
* Username: admin
* Password: admin123

## Tech stack and requirements
* Visual Basic .NET
* .NET 10.0-windows
* SQL Server LocalDB
* Microsoft.Data.SqlClient (v5.2.0)

## Setup and run

### Prerequisites
1. Windows (or macOS running a Windows VM in Parallels).
2. .NET 10 SDK or Visual Studio 2022.
3. SQL Server LocalDB.

### Build and launch
Run these commands in the repository root:

```bash
dotnet restore
dotnet run --project Ambatubus
```

Or open Ambatubus.slnx in Visual Studio and press F5.
