using Shared.DTOs;

namespace Logic.AdapterToGRPC.Item;

public interface IItemClient
{
    Task<Shared.Model.Item> Create(ItemCreationDto dao);
    Task<Shared.Model.Item> Read(ItemSearchDto dao);
    Task<Shared.Model.Item> Delete(ItemSearchDto dao);

}