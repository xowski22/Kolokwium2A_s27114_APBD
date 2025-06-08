using Microsoft.EntityFrameworkCore;

namespace Kolokwium.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Purchase_History")]
[PrimaryKey(nameof(AvailableProgramId), nameof(CustomerId))]
public class Purchase_History
{
    [ForeignKey(nameof(AvailableProgramId))]
    public int AvailableProgramId { get; set; }
    
    [ForeignKey(nameof(CustomerId))]
    public int CustomerId { get; set; }
    
    public DateTime PurchaseDate { get; set; }
    
    public int? Rating { get; set; }
    

}