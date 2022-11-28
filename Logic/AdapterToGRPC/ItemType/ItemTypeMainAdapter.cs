using GRPC.General;
using Shared.DTOs;
using Shared.Model;

namespace Logic.AdapterToGRPC.Item;

public class ItemTypeMainAdapter: IItemTypeClient
{
    private ReadItemTypeAdapter readadp = new ReadItemTypeAdapter();
    private ItemTypeCreateAdapter saveadp = new ItemTypeCreateAdapter();

    public itemType Create(ItemTypeCreationDto dto)
    {
        return saveadp.CreateAdapter(dto);
    }

    public itemType Read(ItemTypeSearchDto dto)
    {
        return readadp.ReadItem(dto);
    }
}