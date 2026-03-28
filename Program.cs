using University_equipment_rental_console_app.Models;


List<Equipment> equipments = new List<Equipment>();

equipments.Add(new Laptop(
    "Laptop do programowania",
    "Dell",
    "Latitude 5520",
    "LAP001",
    "Intel i5",
    16,
    512,
    "nvidia"
));

equipments.Add(new Projector(
    "Projektor do sali A1",
    "Epson",
    "EB-X49",
    "PROJ001",
    "Full HD",
    4000,
    true
));

equipments.Add(new Camera(
    "Kamera do nagrań",
    "Canon",
    "EOS 250D",
    "CAM001",
    24.1,
    true
));

foreach (var equipment in equipments)
{
    Console.WriteLine(equipment);
}

Laptop laptop = new Laptop(
    "Laptop do programowania",
    "Dell",
    "Latitude 5520",
    "LAP001",
    "Intel i5",
    16,
    512,
    "radeon"
);

Console.WriteLine(laptop);

laptop.MarkAsRented();
Console.WriteLine(laptop);

laptop.MarkAsUnavailable();
Console.WriteLine(laptop);

laptop.MarkAsAvailable();
Console.WriteLine(laptop);

User student = new User("s29012", "Jan", "Kowalski", UserType.Student);
User employee = new User("e1234", "Anna", "Nowak", UserType.Employee);


Console.WriteLine(employee);
Console.WriteLine(student);
