package adapter.conver.itemProto;

import Domain.Model.ItemType;
import GRPC.proto.File.*;

public class ConverItem
{
  public static ItemTypeProto itemTypeToItemTypeProto(ItemType itemType)
  {
    return ItemTypeProto.newBuilder()
        .setId(itemType.getId())
        .setDimX(itemType.getDimX())
        .setDimY(itemType.getDimY())
        .setDimZ(itemType.getDimZ())
        .build();
  }
}
