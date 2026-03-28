using University_equipment_rental_console_app.Services;

using University_equipment_rental_console_app.Data;
using University_equipment_rental_console_app.Models;
using University_equipment_rental_console_app.Models.Rentals;
using University_equipment_rental_console_app.Services;

var store = new Store();
var idGenerator = new IdGenerator();
var service = new Service(store);

var student = new Student(idGenerator.GetNextUserId(), "Jan", "Kowalski");
var laptop = new Laptop(idGenerator.GetNextEquipmentId(), "Laptop Kasi", "Lenovo", "xtt", "SN123", "Intel i5", 15, 1000, "nvidia");

service.AddUser(student);
service.AddEquipment(laptop);

Console.WriteLine("-----------------------");
Console.WriteLine($"Student: {student}");
Console.WriteLine($"Sprzęt: {laptop}");
Console.WriteLine($"Ilość wypożyczeń: {store.Rentals.Count}");
Console.WriteLine($"Aktywne wypożyczenia: {service.GetActiveRentalsCount()}");
Console.WriteLine("-----------------------");

service.RentEquipment(student.Id, laptop.Id, 3, idGenerator.GetNextRentalId());

Console.WriteLine();
Console.WriteLine("PO WYPOŻYCZENIU---------------");
Console.WriteLine($"Sprzęt: {laptop}");
Console.WriteLine($"Liczba wypożyczeń: {store.Rentals.Count}");
Console.WriteLine($"Aktywne: {service.GetActiveRentalsCount()}");

var rental = store.Rentals.First();
Console.WriteLine($"Wypożyczenie: {rental}");

service.ReturnEquipment(rental.Id);

Console.WriteLine();
Console.WriteLine("PO ZWROCIE-------------------");
Console.WriteLine($"Sprzęt: {laptop}");
Console.WriteLine($"Wypożyczenie: {rental}");
Console.WriteLine($"Liczba wypożyczeń: {store.Rentals.Count}");
Console.WriteLine($"Aktywne: {service.GetActiveRentalsCount()}");