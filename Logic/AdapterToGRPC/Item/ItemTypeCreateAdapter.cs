
using GRPC.General;
using Shared.DTOs;
using Shared.Model;


namespace Logic.AdapterToGRPC.Item;

public class ItemTypeCreateAdapter
{
    
    private GRPCServerSide _grpcServerSide;
    
    public itemType  CreateAdapter(ItemTypeCreationDto dto)
    {
        ItemTypeCreationRequest itemCreationProto = new ItemTypeCreationRequest{DimX = dto.DimensionX, DimY = dto.DimenstionY, DimZ = dto.DimensionZ};
        ItemType itemTypeProto = _grpcServerSide.CreateItemTypeGRPC(itemCreationProto).Result;
        Shared.Model.itemType itemTypeDomain =
            new itemType(itemCreationProto.Id, itemTypeProto.DimX, itemCreationProto.DimY, itemCreationProto.DimZ);

        return itemTypeDomain;

    }
    
}