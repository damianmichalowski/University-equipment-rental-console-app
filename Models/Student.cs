namespace University_equipment_rental_console_app.Models;

public class Student : User
{
    public string StudentId { get; set; }
    public string Faculty { get; set; }
    public int YearOfStudy { get; set; }
    
    public Student(
        int id,
        string firstName,
        string lastName,
        string email,
        string phoneNumber,
        string studentId,
        string faculty,
        int yearOfStudy
    ) : base(id,  firstName, lastName, email, phoneNumber)
    {
        StudentId = studentId;
        Faculty = faculty;
        YearOfStudy = yearOfStudy;
    }
    
    public override string ToString()
    {
        return base.ToString() + $" | Student ID: {StudentId}, Faculty: {Faculty}, Year: {YearOfStudy}";
    }
}