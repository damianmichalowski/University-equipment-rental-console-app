namespace University_equipment_rental_console_app.Models;

public class Camera : Equipment
{
    public double ResolutionMp { get; set; }
    public bool HasVideo { get; set; }

    public Camera(
        string name,
        string brand,
        string model,
        string serialNumber,
        double resolutionMp,
        bool hasVideo
    ) : base(name, brand, model, serialNumber)
    {
        ResolutionMp = resolutionMp;
        HasVideo = hasVideo;
    }

    public override string ToString()
    {
        return base.ToString() +
               $" | Resolution: {ResolutionMp}MP, Video: {HasVideo}";
    }
}