using University_equipment_rental_console_app.Models;


List<Equipment> equipments = new List<Equipment>();

equipments.Add(new Laptop(
    1,
    "Laptop",
    "Dell",
    "Latitude 5420",
    "SN123",
    "i5",
    16,
    512,
    false
));

equipments.Add(new Projector(
    2,
    "Projektor",
    "Samsung",
    "SP100",
    "SN456",
    "Full HD",
    4000,
    true
));

equipments.Add(new Camera(
    3,
    "Kamera",
    "Canon",
    "EOS 250D",
    "SN789",
    24.1,
    true
));

foreach (var e in equipments)
{
    Console.WriteLine(e);
}