using Shared.DTOs;
using Shared.Model;

namespace Logic.LogicInterfaces;

public interface IItemManager
{
    Task<itemType> createItemTypeAsync(ItemTypeCreationDto dto);
    
}