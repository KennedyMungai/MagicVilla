namespace MagicVilla_VillaAPI.Models.Dto;

public class VillaDTO
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Occupancy { get; set; }
    public int Sqft { get; set; }
    public DateTime CreatedDate { get; set; }
}