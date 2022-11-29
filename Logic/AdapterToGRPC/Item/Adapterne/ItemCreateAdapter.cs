using Microsoft.AspNetCore.Mvc;
using Shared.DTOs;
using Shared.Model;

namespace Logic.AdapterToGRPC.Item.Adapterne;

public class ItemCreateAdapter
{
    private GRPCServerSide _grpcServerSide { get;set; }
    
    public async Task<Shared.Model.Item> createItem(ItemCreationDto dto)
    {

        GRPC.General.ItemCreation itemCreationProto = new GRPC.General.ItemCreation{ItemTypeID = dto.ItemTypeId,ShelfID = dto.shelfId,OwnerID = (int)dto.OwnerId};
        GRPC.General.Item itemProto = await _grpcServerSide.CreateItemGRPCAsync(itemCreationProto);
        
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

            Shared.Model.Item item = new Shared.Model.Item(itemss.Type, itemss.UniqueID, userit, shelf);
            shelf.ItemsOnShelf.Add(item);
        }
        
        
        
        Shared.Model.Item itemDomain =
            new Shared.Model.Item(itemProto.Type,itemProto.UniqueID,user,shelf);

        return itemDomain;
    }
}