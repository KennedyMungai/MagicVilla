using MagicVilla_VillaAPI.Data;
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
        return VillaStore.villaList;
    }

    [HttpGet("{id:int}")]
    public VillaDTO GetVilla(int id)
    {
        return VillaStore.villaList[id];
    }
}