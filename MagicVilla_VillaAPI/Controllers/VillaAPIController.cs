using MagicVilla_VillaAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class VillaAPIController : ControllerBase
{
    public IEnumerable<Villa> GetVillas()
    {
        return new List<Villa> {
            new Villa{Id = 1, Name = "Villa 1"},
            new Villa{Id = 1, Name = "Villa 2"}
        };
    }
}