using Microsoft.AspNetCore.Authentication.Cookies;

namespace Kolokwium.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Program_Entity")]
public class Program_Entity
{
    [Key]
    public int ProgramId { get; set; }
    
    [MaxLength(50)]
    public string Name { get; set; }

    public int DurationMinutes { get; set; }

    public int TemperatureCelsius { get; set; }

    public ICollection<Available_Program> AvailablePrograms { get; set; } = null!;
}