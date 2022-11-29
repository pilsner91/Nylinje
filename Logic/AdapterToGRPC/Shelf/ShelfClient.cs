using Logic.AdapterToGRPC.Shelf.Adp;
using Shared.DTOs;

namespace Logic.AdapterToGRPC.Shelf;

public class ShelfClient : IShelfClient
{
    private ReadShelfAdp _readShelfAdp = new ReadShelfAdp();
    private UpdateShelfAdp _updateShelfAdp = new UpdateShelfAdp();
    
    public async Task<Shared.Model.Shelf> ReadShelf(ShelfSearchParametersDto dao)
    {
        return await _readShelfAdp.ReadShelf(dao);
    }

    public async Task<Shared.Model.Shelf> UpdateShelf(Shared.Model.Shelf dao)
    {
        return await _updateShelfAdp.UpdateShelf(dao);
    }
}