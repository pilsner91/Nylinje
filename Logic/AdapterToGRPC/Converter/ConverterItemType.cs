using GRPC.Proto;
using Shared.DTOs;
using Shared.Model;

namespace Logic.AdapterToGRPC;

public class ConverterItemType
{



    public static ItemTypeCreationRequest ItemTypeToItemTypeProto(ItemTypeCreationDto itemType)
    {
        return new ItemTypeCreationRequest {Id  = itemType.Id,DimX = itemType.DimensionX, DimY = itemType.DimenstionY, DimZ = itemType.DimensionZ };
    }

    public static itemType ItemTypeProtoToItemType(ItemTypeProto itemTypeProto)
    {
      return new itemType(itemTypeProto.Id, itemTypeProto.DimX, itemTypeProto.DimY, itemTypeProto.DimZ);
    }

    public static ItemTypeSearchRequest ItemTypeSearchDtoToItemTypeSearchRequest(ItemTypeSearchDto itemTypeSearchDto)
    {
        return new ItemTypeSearchRequest{Id = itemTypeSearchDto.Id};
    }
   
}