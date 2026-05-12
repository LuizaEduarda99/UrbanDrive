using UrbanDrive.Models.Entities;

Vehicle vehicle = new Vehicle(
    1,
    "ABC-1234",
    "Toyota Corolla",
    150
);

Console.WriteLine("=== URBANDRIVE ===");

Console.WriteLine($"ID: {vehicle.Id}");
Console.WriteLine($"Model: {vehicle.Model}");
Console.WriteLine($"Plate: {vehicle.Plate}");

Console.WriteLine($"Rental for 3 days: {vehicle.CalculateRental(3)}");
