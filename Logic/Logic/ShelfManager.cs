using Logic.AdapterToGRPC.Item;
using Logic.AdapterToGRPC.Shelf;
using Logic.LogicInterfaces;
using Logic.UniversalBussniesClasses;
using Shared.DTOs;
using Shared.Model;

namespace Logic.Logic;

public class ShelfManager : IShelfManager
{
    private IShelfClient _shelfClient;
    private IItemTypeClient _itemTypeClient;

    public ShelfManager(IShelfClient shelfClient, IItemTypeClient itemTypeClient)
    {
        _shelfClient = shelfClient;
        _itemTypeClient = itemTypeClient;
    }

    public async Task<bool> Update(ShelfAddItemRequestDto dtos)
    {
        List<AmountOnSpaceDto> list = await GetAmountOnShelf(dtos.ItemTypeId);

        foreach (AmountOnSpaceDto amount in list)
        {
            amount
        }
    }

    public async Task<List<AmountOnSpaceDto>> GetAmountOnShelf(int itemTypeId)
    {
        List<AmountOnSpaceDto> result = new List<AmountOnSpaceDto>();

        

        itemType _itemType = _itemTypeClient.Read(new ItemTypeSearchDto(itemTypeId)).Result;

        List < Shelf > allShelves= await _shelfClient.GetAllShelves();
        foreach (var shelf in allShelves)
        {
            result.Add(Amount.AmountOnSpaceDto(shelf, _itemType));
        }

        return result;
    }
}