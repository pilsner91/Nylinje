using Shared.DTOs;
using Shared.Model;

namespace HttpClients.ClientInterfaces;

public interface IItemTypeService
{
    Task<itemType> CreateAsync(ItemTypeCreationDto dto);
}