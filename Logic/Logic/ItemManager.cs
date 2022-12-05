using Logic.AdapterToGRPC.Item;
using Logic.AdapterToGRPC.Shelf;
using Logic.LogicInterfaces;
using Microsoft.AspNetCore.Http;
using Shared.DTOs;
using Shared.Model;

namespace Logic.Logic; 

public class ItemManager : IItemLogic, IItemManager
{
    IShelfClient _shelfClient;
    IItemClient _itemClient; 
    IItemTypeClient _itemTypeClient;

    public ItemManager(IShelfClient shelfClient, IItemClient itemClient, IItemTypeClient itemTypeClient)
    {
        _shelfClient = shelfClient;
        _itemClient = itemClient;
        _itemTypeClient = itemTypeClient;
    }

    public async Task<Item> CreateAsync(ItemCreationDto dto)
    {
        if (dto.Antal<=0)
        { 
            throw new Exception("antal skal være mere end 0");
        }

        if (dto.ItemTypeId<=0)
        {
            throw new Exception("itemType skal være større end 0");

        }
        Item result = await _itemClient.Create(dto);
        
        return result;
    }

    public async Task<itemType> CreateItemTypeAsync(ItemTypeCreationDto dto)
    {
        if (dto.Id<1)
        {
            throw new Exception("Id skal være større end 0");
        }

        if (dto.DimensionX<=0)
        {
            throw new Exception("Din X dim skal være større end 0");
        }
        
        if (dto.DimenstionY<=0)
        {
            throw new Exception("Din Y dim skal være større end 0");
        }
        
        if (dto.DimensionZ<=0)
        {
            throw new Exception("Din Z dim skal være større end 0");
        }
        return await _itemTypeClient.Create(dto);
    }

    public async Task<itemType> ReadItemTypeAsync(ItemTypeSearchDto dto)
    {
        try
        {
            itemType result = await _itemTypeClient.Read(dto);
            return result;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
}