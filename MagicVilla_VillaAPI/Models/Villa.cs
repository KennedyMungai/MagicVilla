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
    public string Details { get; set; } = string.Empty;
    public double Rate { get; set; }
    public int Occupancy { get; set; }
    public int Sqft { get; set; }
    public string ImageUrl { get; set; } = String.Empty;
    public string Amenity { get; set; } = String.Empty;
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
}