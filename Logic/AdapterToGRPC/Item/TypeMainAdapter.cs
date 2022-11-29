using Logic.AdapterToGRPC.Item.Adapterne;
using Shared.DTOs;

namespace Logic.AdapterToGRPC.Item;

public class TypeMainAdapter : IItemClient
{
    private ItemCreateAdapter _itemCreateAdapter = new ItemCreateAdapter();
    private ReadItemAdp _readItemAdp = new ReadItemAdp();
    private DeleteItemAdp _deleteItemAdp = new DeleteItemAdp();


    public async Task<Shared.Model.Item> Create(ItemCreationDto dao)
    {

        return await _itemCreateAdapter.createItem(dao);
    }

    public async Task<Shared.Model.Item> Read(ItemSearchDto dao)
    {
        return await _readItemAdp.Read(dao);
    }

    public async Task<Shared.Model.Item> Delete(ItemSearchDto dao)
    {
        return await _deleteItemAdp.Delete(dao);
    }
}