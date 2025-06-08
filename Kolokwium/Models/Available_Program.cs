using Microsoft.EntityFrameworkCore;

namespace Kolokwium.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Available_Program")]
public class Available_Program
{
    [Key]
    public int AvailableProgramId { get; set; }
    
    [ForeignKey(nameof(WashingMachineId))]
    public int WashingMachineId { get; set; }
    
    [ForeignKey(nameof(ProgramId))]
    public int ProgramId { get; set; }
    
    [Column(TypeName = "numeric")]
    [Precision(10, 2)]
    public double Price { get; set; }
    
    public ICollection<Purchase_History> AvailablePurchaseHistories { get; set; } = null!;
}