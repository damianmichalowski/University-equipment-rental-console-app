namespace University_equipment_rental_console_app.Models;

public abstract class Equipment
{

    public int Id { get; }
    public string Name { get; set; }

    public string Brand { get; set; }
    public string Model { get; set; }
    public string SerialNumber { get; set; }

    public EquipmentStatus Status { get; private set; }

    protected Equipment(int id, string name, string brand, string model, string serialNumber)
    {
        Id = id;
        Name = name;
        Brand = brand;
        Model = model;
        SerialNumber = serialNumber;
        Status = EquipmentStatus.Available;
    }

    public void MarkAsRented()
    {
        if (Status != EquipmentStatus.Available)
            throw new Exception("Equipment is not available");

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