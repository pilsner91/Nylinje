using Shared.DTOs;
using Shared.Model;

namespace Logic.AdapterToGRPC.Item;

public class ItemTypeMainAdapter: IItemTypeClient
{
    private ReadItemTypeAdapter readadp = new ReadItemTypeAdapter();
    private ItemTypeCreateAdapter saveadp = new ItemTypeCreateAdapter();

    public async Task<itemType> Create(ItemTypeCreationDto dto)
    {
        return await saveadp.CreateAdapter(dto);
    }

    public async Task<itemType> Read(ItemTypeSearchDto dto)
    {
        return await readadp.ReadItem(dto);
    }
}