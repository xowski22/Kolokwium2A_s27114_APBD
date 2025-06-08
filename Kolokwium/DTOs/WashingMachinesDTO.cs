using Kolokwium.Models;

namespace Kolokwium.DTOs;

public class WashingMachinesDTO
{
    public WashingMachineDTO washingMachine { get; set; }
    public List<Available_Program> availablePrograms { get; set; }
}

