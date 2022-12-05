namespace Shared.DTOs;

public record ShelfAddItemRequestDto
(int ItemTypeId, List<AmountOnSpaceDto> ShelfInfo);