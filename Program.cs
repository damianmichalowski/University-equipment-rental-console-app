using University_equipment_rental_console_app.Models;
using University_equipment_rental_console_app.Models.Rentals;
using University_equipment_rental_console_app.Data;

var store = new Store();

Console.WriteLine("System utworzony poprawnie.");
Console.WriteLine($"Users count: {store.Users.Count}");
Console.WriteLine($"Equipments count: {store.Equipments.Count}");
Console.WriteLine($"Rentals count: {store.Rentals.Count}");