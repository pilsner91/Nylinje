using ClientgRPC;
using GRPC.Proto;
using Shared.DTOs;
using Shared.Model;
using Shelf = Shared.Model.Shelf;

namespace Logic.AdapterToGRPC.Item.Adapterne;

public class ReadItemAdp
{
    GRPCServerSide _grpcServerSide { get;set; }

    public async Task<Shared.Model.Item> Read(ItemSearchDto dao)
    {
        ItemSearchRequest itemSearch = new ItemSearchRequest{Id = dao.id};
        ItemProto itemProto = await _grpcServerSide.GetItemGRPCAsync(itemSearch);
        
        Shared.Model.User user = new Shared.Model.User();
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
            Shared.Model.User userit = new Shared.Model.User();
        
            userit.Id = itemProto.Owner.Id;

            itemType _itemType = new itemType(itemss.Type.Id, itemss.Type.DimX, itemss.Type.DimY, itemss.Type.DimZ);

            Shared.Model.Item item = new Shared.Model.Item(_itemType, itemss.UniqueID, userit, shelf);
            shelf.ItemsOnShelf.Add(item);
        }


        itemType _itemTypeMain =
            new itemType(itemProto.Type.Id, itemProto.Type.DimX, itemProto.Type.DimY, itemProto.Type.DimZ);
        
        Shared.Model.Item itemDomain =
            new Shared.Model.Item(_itemTypeMain,itemProto.UniqueID,user,shelf);

        return itemDomain;
    }
}