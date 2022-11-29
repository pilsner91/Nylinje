using ClientgRPC;
using GRPC.Proto;
using Shared.DTOs;
using Shared.Model;
using Shelf = Shared.Model.Shelf;

namespace Logic.AdapterToGRPC.Item.Adapterne;

public class DeleteItemAdp
{
    private GRPCServerSide _grpcServerSide = new GRPCServerSide();

    public async Task<Shared.Model.Item> Delete(ItemSearchDto dao)
    {
        ItemSearchRequest itemSearch = new ItemSearchRequest{Id = dao.id};
        ItemProto itemProto = await _grpcServerSide.DeleteItemGRPCAsync(itemSearch);
        
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
            itemType itemType = new itemType(itemss.Type.Id, itemss.Type.DimX, itemss.Type.DimY, itemss.Type.DimZ);

            Shared.Model.Item item = new Shared.Model.Item(itemType, itemss.UniqueID, userit, shelf);
            shelf.ItemsOnShelf.Add(item);
        }
        
        
        itemType itemTypedomain = new itemType(itemProto.Type.Id, itemProto.Type.DimX, itemProto.Type.DimY, itemProto.Type.DimZ);

        Shared.Model.Item itemDomain =
            new Shared.Model.Item(itemTypedomain,itemProto.UniqueID,user,shelf);

        return itemDomain;
    }
}