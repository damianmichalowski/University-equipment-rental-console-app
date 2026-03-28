namespace University_equipment_rental_console_app.Models;

public abstract class User
{
    public int Id { get; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public UserType UserType { get; }

    protected User(int id, string firstName, string lastName, UserType userType)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        UserType = userType;
    }

    public abstract int GetRentalLimit();

    public override string ToString()
    {
        return $"ID: {Id}, {FirstName} {LastName}, Type: {UserType}";
    }
}