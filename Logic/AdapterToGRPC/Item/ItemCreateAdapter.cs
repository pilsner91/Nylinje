using GRPC.Item;

namespace Logic.AdapterToGRPC.Item;

public class ItemCreateAdapter
{
    private GRPCServerSide _grpcServerSide;

    public  ItemCreateAdapter(ItemCreateDto dto)
    {
        ItemCreationProto itemCreationProto = new ItemCreationProto();
        itemCreationProto.OwnerId = dto.ownerid;
        itemCreationProto.ShelfId = dto.shelfId;
        itemCreationProto.WareId = dto.wareId;
    }
    
    /*message ItemCreationProto {
        int32 wareId = 1;
        int32 shelf_id = 2;
        int32 owner_id = 3;
    }
    */
}