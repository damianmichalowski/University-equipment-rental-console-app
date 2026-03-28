namespace University_equipment_rental_console_app.Models;

public class Projector : Equipment
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public string SerialNumber { get; set; }
    public string Resolution { get; set; }
    public int BrightnessLumens { get; set; }
    public bool HasHdmi { get; set; }

    public Projector(
        int id,
        string name,
        string brand,
        string model,
        string serialNumber,
        string resolution,
        int brightnessLumens,
        bool hasHdmi
    ) : base(id, name)
    {
        Brand = brand;
        Model = model;
        SerialNumber = serialNumber;
        Resolution = resolution;
        BrightnessLumens = brightnessLumens;
        HasHdmi = hasHdmi;
    }

    public override string ToString()
    {
        return base.ToString() + $" | {Brand} {Model}, SN: {SerialNumber}, {Resolution}, {BrightnessLumens} lm, HDMI: {HasHdmi}";
    }
}