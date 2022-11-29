
using ClientgRPC;
using GRPC.Proto;
using Shared.DTOs;
using Shared.Model;


namespace Logic.AdapterToGRPC.Item;

public class ItemTypeCreateAdapter
{
    
    private GRPCServerSide _grpcServerSide;
    
    public async Task<itemType>  CreateAdapter(ItemTypeCreationDto dto)
    {
        ItemTypeCreationRequest itemCreationProto = new ItemTypeCreationRequest{DimX = dto.DimensionX, DimY = dto.DimenstionY, DimZ = dto.DimensionZ};
        ItemTypeProto itemTypeProto = await _grpcServerSide.CreateItemTypeGRPC(itemCreationProto);
        Shared.Model.itemType itemTypeDomain =
            new itemType(itemCreationProto.Id, itemTypeProto.DimX, itemCreationProto.DimY, itemCreationProto.DimZ);

        return itemTypeDomain;

    }
    
}