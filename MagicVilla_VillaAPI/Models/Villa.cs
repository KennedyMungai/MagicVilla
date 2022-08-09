using System;
using System.ComponentModel.DataAnnotations;

namespace MagicVilla_VillaAPI.Models;

public class Villa
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage = "You have to have a name")]
    [MaxLength(30)]
    public string Name { get; set; } = string.Empty;
    public int Occupancy { get; set; }
    public int SquareFoot { get; set; }
}