namespace University_equipment_rental_console_app.Models;

public class Camera : Equipment
{
    public double ResolutionMp { get; set; }
    public bool HasVideo { get; set; }

    public Camera(
        int id,
        string brand,
        string model,
        string serialNumber,
        double resolutionMp,
        bool hasVideo
    ) : base(id, brand, model, serialNumber)
    {
        ResolutionMp = resolutionMp;
        HasVideo = hasVideo;
    }

    public override string ToString()
    {
        return base.ToString() + $" | Resolution: {ResolutionMp}MP, Has Video: {HasVideo}";
    }
}