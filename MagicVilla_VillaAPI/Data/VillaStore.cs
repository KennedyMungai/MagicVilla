using MagicVilla_VillaAPI.Models.Dto;

namespace MagicVilla_VillaAPI.Data;

public static class VillaStore
{
    public static List<VillaDTO> villaList = new List<VillaDTO>
    {
        new VillaDTO{Id = 1, Name = "Villa 1", Sqft= 100 ,Occupancy= 4},
        new VillaDTO{Id = 2, Name = "Villa 2", Sqft= 100 ,Occupancy= 3}
    };
}