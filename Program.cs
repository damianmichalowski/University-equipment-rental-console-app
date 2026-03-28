using University_equipment_rental_console_app.Data;
using University_equipment_rental_console_app.Models;
using University_equipment_rental_console_app.Services;

Console.WriteLine("SCENARIUSZ DEMONSTRACYJNY");

var store = new Store();
var idGenerator = new IdGenerator();
var service = new Service(store);
var report = new Report(service);

var laptopLenovo = new Laptop(idGenerator.GetNextEquipmentId(), "Laptop Gamingowy", "Lenovo", "Lenovo xyz", "SN123","Intel i5", 64, 1000, "nvidia");
var laptopDell = new Laptop(idGenerator.GetNextEquipmentId(), "Laptop Biurowy", "Dell", "Dell Notebook", "SN1234","Intel i7", 16, 500, "integrated");
var projectorSamsung = new Projector(idGenerator.GetNextEquipmentId(), "Projektor przenośny", "SAMSUNG ", "The Freestyle Smart TV Gen 2", "SN574624", "Full HD", 230, true);
var cameraCanon = new Camera(idGenerator.GetNextEquipmentId(), "Lustrzanka cyfrowa", "CANON", "EOS 2000D","SN475619", 24.7, true);

service.AddEquipment(laptopLenovo);
service.AddEquipment(laptopDell);
service.AddEquipment(projectorSamsung);
service.AddEquipment(cameraCanon);

var student = new Student(idGenerator.GetNextUserId(), "Michał", "Michałowski");
var employee = new Employee(idGenerator.GetNextUserId(), "Jan", "Kowalski");

service.AddUser(student);
service.AddUser(employee);

Console.WriteLine("DOSTĘPNY SPRZĘT:");
foreach (var equipment in service.GetAllEquipment())
{
    Console.WriteLine(equipment);
}

Console.WriteLine();
Console.WriteLine("POPRAWNE WYPOZYCZENIE SPRZĘTU:");
service.RentEquipment(student.Id, laptopLenovo.Id, 3, idGenerator.GetNextRentalId());
service.RentEquipment(student.Id, laptopDell.Id, 3, idGenerator.GetNextRentalId());

var studentRentals = service.GetActiveRentalsForUser(student.Id);
Console.WriteLine($"Wypożyczenie1: {studentRentals[0]}");
Console.WriteLine($"Wypożyczenie2: {studentRentals[1]}");
Console.WriteLine($"Wypozyczony sprzęt1 (status powinien się zmienić): {laptopLenovo}");
Console.WriteLine($"Wypozyczony sprzęt2 (status powinien się zmienić): {laptopDell}");

Console.WriteLine();
Console.WriteLine("NIEPOPRAWNA OPERACJA:");
service.RentEquipment(employee.Id, laptopLenovo.Id, 5, idGenerator.GetNextRentalId());
service.RentEquipment(student.Id, cameraCanon.Id, 3, idGenerator.GetNextRentalId());
Console.WriteLine($"Niepowodzenie dla Wypozyczony sprzęt camera (status nie powinien się zmienić): {cameraCanon}");

Console.WriteLine();
Console.WriteLine("DOSTĘPNY SPRZĘT:");
foreach (var equipment in service.GetAvailableEquipment())
{
    Console.WriteLine(equipment);
}

Console.WriteLine();
Console.WriteLine("AKTYWNE WYPOŻYCZENIA STUDENTA:");
foreach (var rental in service.GetActiveRentalsForUser(student.Id))
{
    Console.WriteLine(rental);
}

Console.WriteLine();
Console.WriteLine("ZWROT SPRZĘTU W TERMINIE:");
service.ReturnEquipment(student.Id,laptopLenovo.Id);
Console.WriteLine("Sprzęt został zwrócony (studnet zwrócił laptop lenovo).");
Console.WriteLine($"Zwrócony sprzęt1 (status powinien się zmienić): {laptopLenovo}");

Console.WriteLine();
Console.WriteLine("AKTYWNE WYPOŻYCZENIA STUDENTA:");
foreach (var rental in service.GetActiveRentalsForUser(student.Id))
{
    Console.WriteLine(rental);
}

Console.WriteLine();
Console.WriteLine("ZWROT OPÓŹNIONY:");
service.RentEquipment(employee.Id, cameraCanon.Id, 1, idGenerator.GetNextRentalId());

Console.WriteLine("AKTYWNE WYPOŻYCZENIA PRACOWNIKA:");
foreach (var rental in service.GetActiveRentalsForUser(employee.Id))
{
    Console.WriteLine(rental);
}

Console.WriteLine("PRACOWNIKA ZWRÓCIŁ SPRZĘT ZA PÓŹNO:");
var lateRental = store.Rentals.First(r => r.Equipment.Id == cameraCanon.Id && r.User.Id == employee.Id && !r.IsReturned);
lateRental.ReturnEquipment(DateTime.Now.AddDays(3));
lateRental.Equipment.MarkAsAvailable();
Console.WriteLine(lateRental);

Console.WriteLine();
Console.WriteLine("OZNACZENIE SPRZĘTU JAKO NIEDOSTĘPNY:");
service.MarkEquipmentAsUnavailable(projectorSamsung.Id);
Console.WriteLine(projectorSamsung);

Console.WriteLine("NIEPOPRAWNA OPERACJA WYPOŻYCZENIE NIEDOSTĘPNEGO SPRZĘTU:");
service.RentEquipment(employee.Id, projectorSamsung.Id, 5, idGenerator.GetNextRentalId());

Console.WriteLine();
report.PrintSummaryReport();