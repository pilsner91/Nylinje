using ClientgRPC;
using GRPC.Item;
using Shared.DTOs;

namespace Logic.AdapterToGRPC.Item;

public class ItemCreateAdapter
{
    private GRPCServerSide _grpcServerSide;

    
    public  ItemCreateAdapter(ItemCreationDto dto)
    {
        ItemCreationProto itemCreationProto = new ItemCreationProto();
        itemCreationProto.OwnerId = dto.OwnerId;
        itemCreationProto.ShelfId = dto.;
        itemCreationProto.WareId = dto.wareId;
    }
    
}