using Shared.DTOs;
using Shared.Model;

namespace Logic.AdapterToGRPC.Item;

public interface IItemTypeClient
{
    itemType Create(ItemTypeCreationDto dto);
    itemType Read(ItemTypeSearchDto dto);

}