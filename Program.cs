using University_equipment_rental_console_app.Data;
using University_equipment_rental_console_app.Models;
using University_equipment_rental_console_app.Services;

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

Console.WriteLine("=== CAŁY SPRZĘT ===");
foreach (var equipment in service.GetAllEquipment())
{
    Console.WriteLine(equipment);
}