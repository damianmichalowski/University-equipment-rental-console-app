namespace University_equipment_rental_console_app.Models;

public class Employee : User
{
    public Employee(int id, string firstName, string lastName)
        : base(id, firstName, lastName, UserType.Employee)
    {
    }

    public override int GetRentalLimit()
    {
        return 5;
    }
}