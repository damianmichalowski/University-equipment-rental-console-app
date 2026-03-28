namespace University_equipment_rental_console_app.Models;

public class Camera : Equipment
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public string SerialNumber { get; set; }
    public double ResolutionMp { get; set; }
    public bool HasVideo { get; set; }

    public Camera(
        int id,
        string name,
        string brand,
        string model,
        string serialNumber,
        double resolutionMp,
        bool hasVideo
    ) : base(id, name)
    {
        Brand = brand;
        Model = model;
        SerialNumber = serialNumber;
        ResolutionMp = resolutionMp;
        HasVideo = hasVideo;
    }

    public override string ToString()
    {
        return base.ToString() + $" | {Brand} {Model}, SN: {SerialNumber}, {ResolutionMp}MP, Video: {HasVideo}";
    }
}