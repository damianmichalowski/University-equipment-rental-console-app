namespace University_equipment_rental_console_app.Services;

public class Report
{
    private readonly Service _service;

    public Report(Service service)
    {
        _service = service;
    }

    public void PrintSummaryReport()
    {
        var allEquipment = _service.GetAllEquipment();
        var availableEquipment = _service.GetAvailableEquipment();
        var activeRentals = _service.GetActiveRentals();
        var overdueRentals = _service.GetOverdueRentals();
        var totalPenalties = _service.GetTotalPenalties();

        Console.WriteLine("RAPORT KOŃCOWY");
        Console.WriteLine($"Wszystkie sprzęty: {allEquipment.Count}");
        Console.WriteLine($"Dostępne sprzęty: {availableEquipment.Count}");
        Console.WriteLine($"Niedostępne lub wypożyczone: {allEquipment.Count - availableEquipment.Count}");
        Console.WriteLine($"Aktywne wypożyczenia: {activeRentals.Count}");
        Console.WriteLine($"Przeterminowane wypożyczenia: {overdueRentals.Count}");
        Console.WriteLine($"Suma naliczonych kar: {totalPenalties} PLN");
    }
}