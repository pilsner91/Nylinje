using ClientgRPC;
using Google.Protobuf.WellKnownTypes;
using GRPC.Proto;

namespace Logic.AdapterToGRPC.Shelf.Adp;

public class GetAllShelves
{
    private readonly IGRPCServerSide _grpcServerSide;

    public GetAllShelves(IGRPCServerSide grpcServerSide)
    {
        _grpcServerSide = grpcServerSide;
    }

    public List<Shared.Model.Shelf> getRequest()
    {
        getAllRequest request = new getAllRequest();
        List<ShelfProto> shelfProtos = _grpcServerSide.GetAllShelfAsync(request);
        
    }
}