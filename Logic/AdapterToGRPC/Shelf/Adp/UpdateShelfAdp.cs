using ClientgRPC;
using GRPC.Proto;
using Shared.Model;


namespace Logic.AdapterToGRPC.Shelf.Adp;

public class UpdateShelfAdp
{
    private readonly IGRPCServerSide _grpcServerSide;

    public UpdateShelfAdp(IGRPCServerSide grpcServerSide)
    {
        _grpcServerSide = grpcServerSide;
    }

    public async Task<Shared.Model.Shelf> UpdateShelf(Shared.Model.Shelf dao)
    {
        ShelfProto shelfRequest = ConverterShelf.ShelfToShelfProto(dao);

        ShelfProto shelfProto = await _grpcServerSide.UpdateSelfAsync(shelfRequest);

        Shared.Model.Shelf shelf = ConverterShelf.ShelfProtoToShelf(shelfProto);
        return shelf;
    }
}