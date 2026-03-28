using University_equipment_rental_console_app.Models;


List<Equipment> equipments = new List<Equipment>();
List<User> users = new List<User>();

equipments.Add(new Laptop(
    1,
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
    "Samsung",
    "SP100",
    "SN456",
    "Full HD",
    4000,
    true
));

equipments.Add(new Camera(
    3,
    "Canon",
    "EOS 250D",
    "SN789",
    24.1,
    true
));

users.Add(new Student(
    1,
    "Jan",
    "Kowalski",
    "kowalski@gmail.com",
    "123 456 789",
    "s29844",
    "informatyka",
    3
    
));

users.Add(new Employee(
    2,
    "Tom",
    "Tomski",
    "tomski@gmail.com",
    "123 456 789",
    "e39844",
    "C# techer",
    "Wydział Informatyki"
    
));
foreach (var e in equipments)
{
    Console.WriteLine(e);
}

foreach (var e in users)
{
    Console.WriteLine(e);
}
