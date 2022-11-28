using Microsoft.AspNetCore.Mvc;
using Shared.DTOs;

namespace Logic.AdapterToGRPC.Item.Adapterne;

public class ItemCreateAdapter
{
    public Shared.Model.Item createItem(ItemCreationDto dto)
    {
        message Item{
            ItemType type = 1;
            int32 UniqueID = 2;
            User owner = 3;
            Shelf shelf = 4;
        }
        message ItemType{
            int32 id = 1;
            double DimX = 2;
            double DimY = 3;
            double DimZ = 4;
        }
        GRPC.General.Item itemCreationProto = new GRPC.General.ItemCreation{ItemTypeID = dto.ItemTypeId,ShelfID = dto.};
        GRPC.General.Item itemTypeProto = .Result;
        Shared.Model.itemType itemTypeDomain =
            new itemType(itemCreationProto.Id, itemTypeProto.DimX, itemCreationProto.DimY, itemCreationProto.DimZ);

        return itemTypeDomain;
    }
}