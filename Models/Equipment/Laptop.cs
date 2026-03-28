namespace University_equipment_rental_console_app.Models;

public class Laptop : Equipment
{
    public string Processor { get; set; }
    public int RamGb { get; set; }
    public int DiskGb { get; set; }
    public string Gpu { get; set; }

    public Laptop(
        int id,
        string name,
        string brand,
        string model,
        string serialNumber,
        string processor,
        int ramGb,
        int diskGb,
        string gpu
    ) : base(id, name, brand, model, serialNumber)
    {
        Processor = processor;
        RamGb = ramGb;
        DiskGb = diskGb;
        Gpu = gpu;
    }

    public override string ToString()
    {
        return base.ToString() +
               $" | CPU: {Processor}, RAM: {RamGb}GB, Disk: {DiskGb}GB, GPU: {Gpu}";
    }
}