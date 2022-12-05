using Shared.DTOs;
using Shared.Model;

namespace HttpClients.ClientInterfaces;

public interface IShelfService
{
    Task<bool> AddItemToShelf(List<ShelfAddItemRequestDto> dto);
    Task<List<Shelf>> getShelfs();
}