using System;
using System.ComponentModel.DataAnnotations;

namespace MagicVilla_VillaAPI.Models;

public class Villa
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required]
    [MaxLength(30)]
    public string Name { get; set; } = string.Empty;
}