using Logic.AdapterToGRPC.Item.Adapterne;
using Shared.DTOs;

namespace Logic.AdapterToGRPC.Item;

public class TypeMainAdapter : IItemClient
{
    private ItemCreateAdapter _itemCreateAdapter = new ItemCreateAdapter();
    
    
    public Shared.Model.Item Create(ItemCreationDto dto)
    {

        return _itemCreateAdapter.createItem(dto);
    }
}