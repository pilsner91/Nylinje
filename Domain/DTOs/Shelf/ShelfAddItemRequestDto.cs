namespace Shared.DTOs;

public record ShelfAddItemRequestDto
(List<int> ItemTypeId, List<AmountOnSpaceDto> ShelfInfo);