namespace Shared.DTOs;

public record ShelfAddItemRequestDto
(List<int>? ItemTypeId,uint Amount, int shelfId);