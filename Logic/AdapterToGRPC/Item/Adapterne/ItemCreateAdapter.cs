using ClientgRPC;
using GRPC.Proto;
using Microsoft.AspNetCore.Mvc;
using Shared.DTOs;
using Shared.Model;

namespace Logic.AdapterToGRPC.Item.Adapterne;

public class ItemCreateAdapter
{
    private readonly IGRPCServerSide _grpcServerSide = new GRPCServerSide();
    

    public async Task<Shared.Model.Item> createItem(ItemCreationDto dto)
    {
        GRPC.Proto.ItemCreation itemCreationProto = ConverterItem.ItemCreationDtoToItemCreation(dto);
        ItemProto itemProto = await _grpcServerSide.CreateItemGRPCAsync(itemCreationProto);

        Shared.Model.Item itemDomain = ConverterItem.ItemProtoToItem(itemProto);
        
        return itemDomain;
    }
}