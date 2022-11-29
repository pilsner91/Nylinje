using Shared.DTOs;
using Shared.Model;

namespace Logic.AdapterToGRPC.Item;

public interface IItemTypeClient
{
    Task<itemType> Create(ItemTypeCreationDto dto);
    Task<itemType> Read(ItemTypeSearchDto dto);

}