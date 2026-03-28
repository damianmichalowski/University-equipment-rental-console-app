namespace University_equipment_rental_console_app.Models;

public class Laptop : Equipment
{
    public int Id { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public string SerialNumber { get; set; }
    public string Processor { get; set; }
    public int RamGb { get; set; }
    public int DiskGb { get; set; }
    public bool HasDedicatedGpu { get; set; }
    
    public Laptop(
        int id,
        string name,
        string brand,
        string model,
        string serialNumber,
        string processor,
        int ramGb,
        int diskGb,
        bool hasDedicatedGpu
    ) : base(id, name)
    {
        Brand = brand;
        Model = model;
        SerialNumber = serialNumber;
        Processor = processor;
        RamGb = ramGb;
        DiskGb = diskGb;
        HasDedicatedGpu = hasDedicatedGpu;
    }
    public override string ToString()
    {
        return base.ToString() +$" | {Brand} {Model}, SN: {SerialNumber}, RAM: {RamGb}GB, CPU: {Processor}, Disk: {DiskGb}GB, HasDedicatedGpu: {HasDedicatedGpu}";
    }
}