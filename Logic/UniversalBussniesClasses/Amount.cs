using Shared.DTOs;
using Shared.Model;

namespace Logic.UniversalBussniesClasses;

public class Amount
{
    public static AmountOnSpaceDto AmountOnSpaceDto(Shelf shelf, itemType _itemType)
    {
        double volumenShelf = shelf.DimX * shelf.DimY * shelf.DimZ;
        double volumenItemType = _itemType.DimX * _itemType.DimY * _itemType.DimZ;

        foreach (Item item in shelf.ItemsOnShelf)
        {
            volumenShelf -= item.Type.DimX * item.Type.DimY * item.Type.DimZ;
        }

        return new AmountOnSpaceDto(shelf.RowNo+shelf.ShelfNo,(int?)Math.Floor(volumenShelf / volumenItemType));
    }
}