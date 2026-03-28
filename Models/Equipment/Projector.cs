namespace University_equipment_rental_console_app.Models;

public class Projector : Equipment
{
    public string Resolution { get; set; }
    public int BrightnessLumens { get; set; }
    public bool HasHdmi { get; set; }

    public Projector(
        string name,
        string brand,
        string model,
        string serialNumber,
        string resolution,
        int brightnessLumens,
        bool hasHdmi
    ) : base(name, brand, model, serialNumber)
    {
        Resolution = resolution;
        BrightnessLumens = brightnessLumens;
        HasHdmi = hasHdmi;
    }

    public override string ToString()
    {
        return base.ToString() +
               $" | Resolution: {Resolution}, Brightness: {BrightnessLumens} lm, HDMI: {HasHdmi}";
    }
}