namespace University_equipment_rental_console_app.Models;

public abstract class Equipment
{
    private static int _nextId = 1;

    public int Id { get; }
    public string Name { get; set; }

    public string Brand { get; set; }
    public string Model { get; set; }
    public string SerialNumber { get; set; }

    public EquipmentStatus Status { get; private set; }

    protected Equipment(string name, string brand, string model, string serialNumber)
    {
        Id = _nextId++;
        Name = name;
        Brand = brand;
        Model = model;
        SerialNumber = serialNumber;
        Status = EquipmentStatus.Available;
    }

    public void MarkAsRented()
    {
        Status = EquipmentStatus.Rented;
    }

    public void MarkAsAvailable()
    {
        Status = EquipmentStatus.Available;
    }

    public void MarkAsUnavailable()
    {
        Status = EquipmentStatus.Unavailable;
    }

    public override string ToString()
    {
        return $"ID: {Id}, {Name}, {Brand} {Model}, SN: {SerialNumber}, Status: {Status}";
    }
}