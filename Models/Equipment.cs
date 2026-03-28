namespace University_equipment_rental_console_app.Models;

public abstract class Equipment
{
    public int Id { get; }
    public string Name { get; set; }
    public EquipmentStatus Status { get; set; }

    protected Equipment(int id, string name)
    {
        Id = id;
        Name = name;
        Status = EquipmentStatus.Available;
    }

    public override string ToString()
    {
        return $"Equipment - ID: {Id}, Name: {Name}, Status: {Status}";
    }
}