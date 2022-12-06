using ClientgRPC;
using GRPC.Proto;
using Shared.DTOs;
using Shared.Model;

namespace Logic.AdapterToGRPC.Item;

public class ReadItemTypeAdapter
{
    private readonly IGRPCServerSide _grpcServerSide = new GRPCServerSide();
/*
    public ReadItemTypeAdapter(IGRPCServerSide grpcServerSide)
    {
        _grpcServerSide = grpcServerSide;
    }
*/
    public async Task<itemType> ReadItem(ItemTypeSearchDto dto)
    {
        ItemTypeSearchRequest itemTypeSearch = ConverterItemType.ItemTypeSearchDtoToItemTypeSearchRequest(dto);
        ItemTypeProto itemTypeProto = await _grpcServerSide.SearchItemTypeGRPC(itemTypeSearch);
        Shared.Model.itemType itemTypeDomain = ConverterItemType.ItemTypeProtoToItemType(itemTypeProto);

        return itemTypeDomain;

    }
}