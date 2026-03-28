namespace University_equipment_rental_console_app.Models;

public class Laptop : Equipment
{
    public string Processor { get; set; }
    public int RamGb { get; set; }
    public int DiskGb { get; set; }
    public bool HasDedicatedGpu { get; set; }
    
    public Laptop(
        int id,
        string brand,
        string model,
        string serialNumber,
        string processor,
        int ramGb,
        int diskGb,
        bool hasDedicatedGpu
    ) : base(id, brand, model, serialNumber)
    {
        Processor = processor;
        RamGb = ramGb;
        DiskGb = diskGb;
        HasDedicatedGpu = hasDedicatedGpu;
    }
    public override string ToString()
    {
        return base.ToString() +$" | RAM: {RamGb}GB, CPU: {Processor}, Disk: {DiskGb}GB, Has Dedicated Gpu: {HasDedicatedGpu}";
    }
}