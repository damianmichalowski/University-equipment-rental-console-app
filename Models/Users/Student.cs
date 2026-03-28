namespace University_equipment_rental_console_app.Models;

public class Student : User
{
    public Student(int id, string firstName, string lastName)
        : base(id, firstName, lastName, UserType.Student)
    {
    }

    public override int GetRentalLimit()
    {
        return 2;
    }
}