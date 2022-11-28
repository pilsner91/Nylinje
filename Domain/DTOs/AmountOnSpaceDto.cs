namespace Shared.DTOs;

public record AmountOnSpaceDto
{
    public int? ShelfID { get; set; }
    public int? AvalibleSpace { get; set; }

}