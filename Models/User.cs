namespace University_equipment_rental_console_app.Models;

public abstract class User
{
    public int Id { get; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    
    public string FullName => $"{FirstName} {LastName}";
    
    protected User(int id, string firstName, string lastName, string email, string phoneNumber)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PhoneNumber = phoneNumber;
    }
    
    public override string ToString()
    {
        return $"ID: {Id}, {FullName}, Email: {Email}";
    }
}