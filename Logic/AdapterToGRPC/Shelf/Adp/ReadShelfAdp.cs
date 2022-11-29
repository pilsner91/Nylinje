using GRPC.General;
using Logic.AdapterToGRPC.Item.Adapterne;
using Shared.DTOs;

namespace Logic.AdapterToGRPC.Shelf.Adp;

public class ReadShelfAdp
{
    GRPCServerSide _grpcServerSide { get;set; }

    public async Task<Shared.Model.Shelf> ReadShelf(ShelfSearchParametersDto dao){
    ShelfSearchRequest shelfSearchRequest = new ShelfSearchRequest{Id = dao.id};
            GRPC.General.Shelf shelfProto = await _grpcServerSide.ReadShelfAsync(shelfSearchRequest);
        
            
            Shared.Model.Shelf shelf = new Shared.Model.Shelf();
            shelf.DimX = shelfProto.DimX;
            shelf.DimY = shelfProto.Dimy;
            shelf.DimZ = shelfProto.Dimz;
            shelf.RowNo = shelfProto.RowNo;
            shelf.ShelfNo = shelfProto.ShelfNo;
            
            shelf.ItemsOnShelf = new List<Shared.Model.Item>();
            foreach (var itemss in shelfProto.ItemsOnShelf)
            {
                Shared.Model.User userit = new Shared.Model.User();
            
                userit.Id = itemss.Owner.Id;
    
                Shared.Model.Item item = new Shared.Model.Item(itemss.Type, itemss.UniqueID, userit, shelf);
                shelf.ItemsOnShelf.Add(item);
            }



            return shelf;
    }
}