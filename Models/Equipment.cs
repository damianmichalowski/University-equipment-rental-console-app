namespace University_equipment_rental_console_app.Models;

public abstract class Equipment
{
    public int Id { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Name => $"{Brand} {Model}";
    public string SerialNumber { get; set; }
    public EquipmentStatus Status { get; set; }

    protected Equipment(int id, string brand, string model, string serialNumber)
    {
        Id = id;
        Brand = brand;
        Model = model;
        SerialNumber = serialNumber;
        Status = EquipmentStatus.Available;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}, SN: {SerialNumber}, Status: {Status}";
    }
}