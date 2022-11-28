namespace Shared.DTOs;

public record ItemRegisterReqiestDto
(
    int? ItemType,
    List<AmountOnSpaceDto> ShelfInfo);  