using Logic.AdapterToGRPC.Shelf.Adp;
using Shared.DTOs;

namespace Logic.AdapterToGRPC.Shelf;

public class ShelfClient : IShelfClient
{
    private readonly ReadShelfAdp _readShelfAdp;
    private readonly UpdateShelfAdp _updateShelfAdp;

    public ShelfClient(ReadShelfAdp readShelfAdp, UpdateShelfAdp updateShelfAdp)
    {
        _readShelfAdp = readShelfAdp;
        _updateShelfAdp = updateShelfAdp;
    }

    public async Task<Shared.Model.Shelf> ReadShelf(ShelfSearchParametersDto dao)
    {
        return await _readShelfAdp.ReadShelf(dao);
    }

    public async Task<Shared.Model.Shelf> UpdateShelf(Shared.Model.Shelf dao)
    {
        return await _updateShelfAdp.UpdateShelf(dao);
    }

    public Task<List<Shared.Model.Shelf>> GetAllShelves()
    {
        throw new NotImplementedException();
    }
}