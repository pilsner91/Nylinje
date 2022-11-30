package adapter.converter.itemTypeProto;

import Domain.Model.ItemType;
import GRPC.proto.File.*;

public class ConverterItemType
{
  public static ItemTypeProto itemType_To_ItemTypeProto(ItemType itemType)
  {
    return ItemTypeProto.newBuilder()
        .setId(itemType.getId())
        .setDimX(itemType.getDimX())
        .setDimY(itemType.getDimY())
        .setDimZ(itemType.getDimZ())
        .build();
  }
}
