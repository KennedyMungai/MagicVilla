using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers;

[ApiController]
[Route("api/VillaAPI")]
public class VillaAPIController : ControllerBase
{
    [HttpGet]
    public IEnumerable<VillaDTO> GetVillas()
    {
        return new List<VillaDTO> {
            new VillaDTO{Id = 1, Name = "Villa 1", CreatedDate = DateTime.Now},
            new VillaDTO{Id = 1, Name = "Villa 2", CreatedDate = DateTime.Now}
        };
    }
}