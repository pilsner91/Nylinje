using Logic.LogicInterfaces;

namespace WebAPI.Controllers;

public class ShelfController
{
    private readonly IShelfManager _shelfManager;

    public ShelfController(IShelfManager shelfManager)
    {
        _shelfManager = shelfManager;
    }
    
    
}