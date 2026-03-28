using University_equipment_rental_console_app.Models;
using University_equipment_rental_console_app.Models.Rentals;
namespace University_equipment_rental_console_app.Data;

public class Store
{
    public List<User> Users { get; } = new();
    public List<Equipment> Equipments { get; } = new();
    public List<Rental> Rentals { get; } = new();
}