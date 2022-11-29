using ClientgRPC;
using GRPC.Proto;
using Microsoft.AspNetCore.Mvc;
using Shared.DTOs;
using Shared.Model;

namespace Logic.AdapterToGRPC.Item.Adapterne;

public class ItemCreateAdapter
{
    private GRPCServerSide _grpcServerSide { get;set; }
    
    public async Task<Shared.Model.Item> createItem(ItemCreationDto dto)
    {

        GRPC.Proto.ItemCreation itemCreationProto = new GRPC.Proto.ItemCreation{ItemTypeID = dto.ItemTypeId,ShelfID = (int)dto.shelfId,OwnerID = dto.OwnerId};
        ItemProto itemProto = await _grpcServerSide.CreateItemGRPCAsync(itemCreationProto);
        
        User user = new User();
        user.Id = itemProto.Owner.Id;
        
        Shared.Model.Shelf shelf = new Shared.Model.Shelf();
        shelf.DimX = itemProto.Shelf.Dimz;
        shelf.DimY = itemProto.Shelf.Dimy;
        shelf.DimZ = itemProto.Shelf.Dimz;
        shelf.RowNo = itemProto.Shelf.RowNo;
        shelf.ShelfNo = itemProto.Shelf.ShelfNo;
        
        shelf.ItemsOnShelf = new List<Shared.Model.Item>();
        foreach (var itemss in itemProto.Shelf.ItemsOnShelf)
        {
            User userit = new User();
        
            userit.Id = itemProto.Owner.Id;

            itemType _itemType = new itemType(itemss.Type.Id, itemss.Type.DimX, itemss.Type.DimY, itemss.Type.DimZ);

            
            Shared.Model.Item item = new Shared.Model.Item(_itemType, itemss.UniqueID, userit, shelf);
            shelf.ItemsOnShelf.Add(item);
        }
        
        itemType itemTypedomain = new itemType(itemProto.Type.Id, itemProto.Type.DimX, itemProto.Type.DimY, itemProto.Type.DimZ);

        
        Shared.Model.Item itemDomain =
            new Shared.Model.Item(itemTypedomain,itemProto.UniqueID,user,shelf);

        return itemDomain;
    }
}