using Kolokwium.Models;

namespace Kolokwium.DTOs;

public class CustomerOrderDTO
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string phoneNumber { get; set; }
    List<PurchasesDTO> purchases { get; set; } = null!;
    
}

public class PurchasesDTO
{
    public DateTime date { get; set; }
    public int rating { get; set; }
    public double price { get; set; }
    public WashingMachineDTO washingMachine { get; set; } = null!;
    public ProgramDTO program { get; set; } = null!;
}

