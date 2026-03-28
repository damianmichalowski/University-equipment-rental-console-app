namespace University_equipment_rental_console_app.Models;

public class User
{
    public string Id { get; set; }   // np. "s29012", "e1234"
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public UserType UserType { get; set; }

    public User(string id, string firstName, string lastName, UserType userType)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        UserType = userType;
    }

    public override string ToString()
    {
        return $"ID: {Id}, {FirstName} {LastName}, Type: {UserType}";
    }
}