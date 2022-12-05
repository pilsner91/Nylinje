using Logic.LogicInterfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.DTOs;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ShelfController : ControllerBase
{
    private readonly IShelfManager _shelfManager;

    public ShelfController(IShelfManager shelfManager)
    {
        _shelfManager = shelfManager;
    }

    [HttpPatch]
    public async Task<ActionResult<bool>> update(ShelfAddItemRequestDto dtos)
    {
        
        try
        {
            bool succes = await _shelfManager.Update(dtos);
            if (succes)
            {
                return Ok();
            }
            return StatusCode(500, "something went wrong");
        }
        catch(Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
}