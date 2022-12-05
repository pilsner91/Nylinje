using ClientgRPC;
using GRPC.Proto;
using Logic.AdapterToGRPC.Item.Adapterne;
using Shared.DTOs;
using Shared.Model;

namespace Logic.AdapterToGRPC.Shelf.Adp;

public class ReadShelfAdp
{
    GRPCServerSide _grpcServerSide { get;set; }

    public async Task<Shared.Model.Shelf> ReadShelf(ShelfSearchParametersDto dao){
    ShelfSearchRequest shelfSearchRequest = new ShelfSearchRequest{Id = dao.id};
            ShelfProto shelfProto = await _grpcServerSide.ReadShelfAsync(shelfSearchRequest);

            Shared.Model.Shelf shelf = ConverterShelf.ShelfProtoToShelf(shelfProto);
            




            return shelf;
    }
}