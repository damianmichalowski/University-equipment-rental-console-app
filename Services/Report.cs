namespace University_equipment_rental_console_app.Services;
using University_equipment_rental_console_app.Services;

public class Report
{
    private readonly Service _Service;

    public Report(Service service)
    {
        _Service = service;
    }

    public void PrintSummaryReport()
    {
        var allEquipment = _Service.GetAllEquipment();
        var availableEquipment = _Service.GetAvailableEquipment();
        var activeRentals = _Service.GetActiveRentals();
        var overdueRentals = _Service.GetOverdueRentals();
        var totalPenalties = _Service.GetTotalPenalties();

        Console.WriteLine("RAPORT KOŃCOWY");
        Console.WriteLine($"Wszystkie sprzęty: {allEquipment.Count}");
        Console.WriteLine($"Dostępne sprzęty: {availableEquipment.Count}");
        Console.WriteLine($"Niedostępne lub wypożyczone: {allEquipment.Count - availableEquipment.Count}");
        Console.WriteLine($"Aktywne wypożyczenia: {activeRentals.Count}");
        Console.WriteLine($"Przeterminowane wypożyczenia: {overdueRentals.Count}");
        Console.WriteLine($"Suma naliczonych kar: {totalPenalties} PLN");
    }
}