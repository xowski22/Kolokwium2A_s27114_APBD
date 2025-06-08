namespace Kolokwium.Models;

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Washing_Machine")]
public class Washing_Machine
{
    [Key]
    public int WashingMachineId { get; set; }
    
    [Column(TypeName = "numeric")]
    [Precision(10, 2)]
    public double MaxWeight { get; set; }
    
    [MaxLength(100)]
    public string SerialNumber { get; set; }
    
    public ICollection<Available_Program> AvailablePrograms { get; set; } = null!;
    
}