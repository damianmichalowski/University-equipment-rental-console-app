using University_equipment_rental_console_app.Data;
using University_equipment_rental_console_app.Models;
using University_equipment_rental_console_app.Models.Rentals;
namespace University_equipment_rental_console_app.Services;

public class Service
{
    private readonly Store _store;

    public Service(Store store)
    {
        _store = store;
    }

    public void AddUser(User user)
    {
        _store.Users.Add(user);
    }

    public void AddEquipment(Equipment equipment)
    {
        _store.Equipments.Add(equipment);
    }
    
    public List<Equipment> GetAllEquipment()
    {
        return _store.Equipments;
    }

    public List<Equipment> GetAvailableEquipment()
    {
        return _store.Equipments
            .Where(e => e.Status == EquipmentStatus.Available)
            .ToList();
    }
    
    public void MarkEquipmentAsUnavailable(int equipmentId)
    {
        var equipment = _store.Equipments.FirstOrDefault(e => e.Id == equipmentId);

        if (equipment == null)
            throw new Exception("Equipment not found");

        equipment.MarkAsUnavailable();
    }

    public void RentEquipment(int userId, int equipmentId, int rentalDays, int rentalId)
    {
        var user = _store.Users.FirstOrDefault(u => u.Id == userId);
        var equipment = _store.Equipments.FirstOrDefault(e => e.Id == equipmentId);

        if (user == null)
            throw new Exception("User not found");

        if (equipment == null)
            throw new Exception("Equipment not found");

        if (equipment.Status != EquipmentStatus.Available)
            throw new Exception("Equipment is not available");

        int activeRentals = _store.Rentals.Count(r => r.User.Id == userId && !r.IsReturned);

        if (activeRentals >= user.GetRentalLimit())
            throw new Exception("User reached rental limit");

        var rental = new Rental(rentalId, user, equipment, DateTime.Now, rentalDays);

        _store.Rentals.Add(rental);
        equipment.MarkAsRented();
    }

    public void ReturnEquipment(int rentalId)
    {
        var rental = _store.Rentals.FirstOrDefault(r => r.Id == rentalId);

        if (rental == null)
            throw new Exception("Rental not found");

        if (rental.IsReturned)
            throw new Exception("Already returned");

        rental.ReturnEquipment(DateTime.Now);
        rental.Equipment.MarkAsAvailable();
    }

    public List<Rental> GetActiveRentals()
    {
        return _store.Rentals.Where(r => !r.IsReturned).ToList();
    }

    public int GetActiveRentalsCount()
    {
        return GetActiveRentals().Count;
    }
    
    public List<Rental> GetActiveRentalsForUser(int userId)
    {
        return _store.Rentals
            .Where(r => r.User.Id == userId && !r.IsReturned)
            .ToList();
    }
    
    public List<Rental> GetOverdueRentals()
    {
        return _store.Rentals
            .Where(r => r.IsOverdue)
            .ToList();
    }

    public decimal GetTotalPenalties()
    {
        return _store.Rentals.Sum(r => r.Penalty);
    }
}