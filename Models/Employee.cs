namespace University_equipment_rental_console_app.Models;

public class Employee : User
{
    public string EmployeeId { get; set; }
    public string Position { get; set; }
    public string Department { get; set; }

    public Employee(
        int id,
        string firstName,
        string lastName,
        string email,
        string phoneNumber,
        string employeeId,
        string position,
        string department
    ) : base(id, firstName, lastName, email, phoneNumber)
    {
        EmployeeId = employeeId;
        Position = position;
        Department = department;
    }

    public override string ToString()
    {
        return base.ToString() + $" | Employee ID: {EmployeeId}, Position: {Position}, Dept: {Department}";
    }
}