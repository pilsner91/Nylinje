
using ClientgRPC;
using GRPC.Proto;
using Shared.DTOs;
using Shared.Model;


namespace Logic.AdapterToGRPC.Item;

public class ItemTypeCreateAdapter
{
    
    private readonly IGRPCServerSide _grpcServerSide = new GRPCServerSide();
/*
    public ItemTypeCreateAdapter(IGRPCServerSide grpcServerSide)
    {
        _grpcServerSide = grpcServerSide;
    }
*/
    public async Task<itemType>  CreateAdapter(ItemTypeCreationDto dto)
    {
        ItemTypeCreationRequest itemCreationProt = ConverterItemType.ItemTypeToItemTypeProto(dto);
        ItemTypeProto itemTypeProto = await _grpcServerSide.CreateItemTypeGRPC(itemCreationProt);
        Shared.Model.itemType itemTypeDomain = ConverterItemType.ItemTypeProtoToItemType(itemTypeProto);
            
        return itemTypeDomain;

    }
    
}