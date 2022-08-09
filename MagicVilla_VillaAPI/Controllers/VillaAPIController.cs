using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers;

[ApiController]
[Route("api/VillaAPI")]
public class VillaAPIController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult<IEnumerable<VillaDTO>> GetVillas()
    {
        return Ok(VillaStore.villaList);
    }

    [HttpGet("{id:int}", Name="GetVilla")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<VillaDTO> GetVilla(int id)
    {
        if (id == 0)
        {
            return BadRequest();
        }

        var villa = VillaStore.villaList.FirstOrDefault(u => u.Id == id);

        if(villa is null)
        {
            return NotFound();
        }

        return Ok(villa);
    } 

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public ActionResult<VillaDTO> CreateVilla([FromBody]VillaDTO villaDTO)
    {
        if(villaDTO is null)
        {
            return BadRequest(villaDTO);
        }

        if(villaDTO.Id > 0)
        {
            return StatusCode(StatusCodes.Status500InternalServerError);
        }

        villaDTO.Id = VillaStore.villaList
                        .OrderByDescending(u => u.Id)
                        .FirstOrDefault()
                        .Id + 1;

        VillaStore.villaList.Add(villaDTO);

        return CreatedAtRoute("GetVilla", new {id = villaDTO.Id}, villaDTO);
    }
}