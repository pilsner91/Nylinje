using Shared.DTOs;

namespace Logic.LogicInterfaces;

public interface IShelfManager
{
    Task<bool> Update(List<ShelfAddItemRequestDto> dtos);
}