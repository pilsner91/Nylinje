using Shared.DTOs;

namespace HttpClients.ClientInterfaces;

public interface IShelfService
{
    Task<bool> AddItemToShelf(List<ShelfAddItemRequestDto> dto);
}