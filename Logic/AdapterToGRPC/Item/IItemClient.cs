using Shared.DTOs;

namespace Logic.AdapterToGRPC.Item;

public interface IItemClient
{
    Shared.Model.Item Create(ItemCreationDto dto);

}