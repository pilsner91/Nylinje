using Logic.LogicInterfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.DTOs;
using Shared.Model;

namespace WebAPI.Controllers; 

[ApiController]
[Route("[Controller]")]
public class WaresController : ControllerBase {

    private IItemLogic _itemLogic;


    public WaresController(IItemLogic itemLogic) {
        this._itemLogic = itemLogic;
    }

    [HttpPost]
    public async Task<ActionResult<Shared.Model.Item>> CreateAsync(ItemCreationDto dto) {
        try {
            Shared.Model.Item item = await _itemLogic.CreateAsync(dto);
            return Created($"/todos/{item.Uid}", item);
        }
        catch (Exception e) {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
}