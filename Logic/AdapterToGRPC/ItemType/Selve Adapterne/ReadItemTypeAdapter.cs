using GRPC.General;
using Shared.DTOs;
using Shared.Model;

namespace Logic.AdapterToGRPC.Item;

public class ReadItemTypeAdapter
{
    private GRPCServerSide _grpcServerSide;
    
    public async Task<itemType> ReadItem(ItemTypeSearchDto dto)
    {
        ItemTypeSearchRequest itemTypeSearch = new ItemTypeSearchRequest{Id = dto.id};
        ItemType itemTypeProto = await _grpcServerSide.SearchItemTypeGRPC(itemTypeSearch);
        Shared.Model.itemType itemTypeDomain =
            new itemType(itemTypeProto.Id, itemTypeProto.DimX, itemTypeProto.DimY, itemTypeProto.DimZ);

        return itemTypeDomain;

    }
}