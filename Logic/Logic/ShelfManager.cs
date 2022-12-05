using System.Runtime.InteropServices;
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
    private IItemClient _itemClient;

    public ShelfManager(IShelfClient shelfClient, IItemTypeClient itemTypeClient, IItemClient itemClient)
    {
        _shelfClient = shelfClient;
        _itemTypeClient = itemTypeClient;
        _itemClient = itemClient;
    }

    public async Task<bool> Update(ShelfAddItemRequestDto dtos)
    {
        if (await HasRoom(dtos))
        {
            return false;
        }

 
        
        

        foreach(AmountOnSpaceDto antalPåHylde in dtos.ShelfInfo)
        {
            
            
            for (int i = 0; i < antalPåHylde.AvalibleSpace; i++)
            {
                ItemCreationDto newItem = new ItemCreationDto(dtos.ItemTypeId,)
                Item item = _itemClient.Create(I)
            }
        }

        return true;
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

    public async Task<bool> HasRoom(ShelfAddItemRequestDto dtos)
    {
        List<AmountOnSpaceDto> list = await GetAmountOnShelf(dtos.ItemTypeId);
        foreach (AmountOnSpaceDto spaces in list)
        {
            foreach (AmountOnSpaceDto places in dtos.ShelfInfo)
            {
                if (spaces.ShelfID.Equals(places.ShelfID))
                {
                    if (spaces.AvalibleSpace<places.AvalibleSpace)
                    {
                        throw new Exception("To many Item on shelf");
                    }
                }
            }
        }

        return true;
    }
}