namespace University_equipment_rental_console_app.Models.Rentals;

public class Rental
{
    public int Id { get; }
    public User User { get; }
    public Equipment Equipment { get; }
    public DateTime RentalDate { get; }
    public DateTime DueDate { get; }
    public DateTime? ReturnDate { get; private set; }
    public decimal Penalty { get; private set; }
    private const decimal PenaltyPerDay = 10m;

    public bool IsReturned => ReturnDate.HasValue;

    public bool IsOverdue => !IsReturned && DateTime.Now > DueDate;

    public Rental(int id, User user, Equipment equipment, DateTime rentalDate, int rentalDays)
    {
        Id = id;
        User = user;
        Equipment = equipment;
        RentalDate = rentalDate;
        DueDate = rentalDate.AddDays(rentalDays);
        Penalty = 0;
    }

    public void ReturnEquipment(DateTime returnDate)
    {
        ReturnDate = returnDate;

        if (returnDate.Date <= DueDate.Date)
            return;

        var lateDays = (returnDate.Date - DueDate.Date).Days;
        Penalty = lateDays * PenaltyPerDay;
    }

    public override string ToString()
    {
        var returnedText = ReturnDate.HasValue ? ReturnDate.Value.ToShortDateString() : "No";

        return $"Rental ID: {Id}, User: {User.FirstName} {User.LastName}, Equipment: {Equipment.Name}, " +
               $"Rental date: {RentalDate.ToShortDateString()}, Due date: {DueDate.ToShortDateString()}, " +
               $"Returned: {returnedText}, Penalty: {Penalty} PLN";
    }
}