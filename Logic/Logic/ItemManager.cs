using Logic.AdapterToGRPC.Item;
using Logic.AdapterToGRPC.Shelf;
using Logic.LogicInterfaces;
using Shared.DTOs;
using Shared.Model;

namespace Logic.Logic; 

public class ItemManager : IItemLogic, IItemManager
{
    IShelfClient _shelfClient;
    IItemClient _itemClient;
    IItemTypeClient _itemTypeClient;
    
    public async Task<Item> CreateAsync(ItemCreationDto dto)
    {
        return await _itemClient.Create(dto);
    }

    public async Task<itemType> createItemAsync(ItemTypeCreationDto dto)
    {
        return await _itemTypeClient.Create(dto);
    }


}