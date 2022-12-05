using Shared.DTOs;
using Shared.Model;

namespace Logic.AdapterToGRPC.Item;

public class ItemTypeMainAdapter: IItemTypeClient
{
    
    private readonly ItemTypeCreateAdapter saveadp;
    private readonly ReadItemTypeAdapter readadp;

    public ItemTypeMainAdapter(ItemTypeCreateAdapter saveadp, ReadItemTypeAdapter readadp)
    {
        this.saveadp = saveadp;
        this.readadp = readadp;
    }

    public async Task<itemType> Create(ItemTypeCreationDto dto)
    {
        
        return await saveadp.CreateAdapter(dto);
    }

    public async Task<itemType> Read(ItemTypeSearchDto dto)
    {

        
 
        return await readadp.ReadItem(dto);
    }
}