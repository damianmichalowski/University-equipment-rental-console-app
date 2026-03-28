namespace University_equipment_rental_console_app.Services;

public class IdGenerator
{
    private int _nextEquipmentId = 1;
    private int _nextUserId = 1;
    private int _nextRentalId = 1;

    public int GetNextEquipmentId()
    {
        return _nextEquipmentId++;
    }

    public int GetNextUserId()
    {
        return _nextUserId++;
    }

    public int GetNextRentalId()
    {
        return _nextRentalId++;
    }
}