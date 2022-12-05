using Logic.AdapterToGRPC.Shelf;
using Logic.LogicInterfaces;
using Shared.DTOs;
using Shared.Model;

namespace Logic.Logic;

public class ShelfManager : IShelfManager
{
    private ShelfClient _shelfClient;

    public ShelfManager(ShelfClient shelfClient)
    {
        _shelfClient = shelfClient;
    }

    public Task<bool> Update(List<ShelfAddItemRequestDto> dtos)
    {
        throw new NotImplementedException();
    }

    public Task<List<AmountOnSpaceDto>> GetAmountOnShelf(int ItemTypeId)
    {
        List<AmountOnSpaceDto> result = new List<AmountOnSpaceDto>();  
        
        
        
        return _shelfClient.
    }
}