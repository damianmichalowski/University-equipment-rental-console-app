namespace University_equipment_rental_console_app.Models;

public class Projector : Equipment
{
    public string Resolution { get; set; }
    public int BrightnessLumens { get; set; }
    public bool HasHdmi { get; set; }

    public Projector(
        int id,
        string brand,
        string model,
        string serialNumber,
        string resolution,
        int brightnessLumens,
        bool hasHdmi
    ) : base(id, brand, model, serialNumber)
    {
        Resolution = resolution;
        BrightnessLumens = brightnessLumens;
        HasHdmi = hasHdmi;
    }

    public override string ToString()
    {
        return base.ToString() + $" | Resolution {Resolution}, {BrightnessLumens} lm, HDMI: {HasHdmi}";
    }
}