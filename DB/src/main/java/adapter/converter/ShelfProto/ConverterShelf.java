package adapter.converter.ShelfProto;

import Domain.Model.Item;
import Domain.Model.Shelf;
import GRPC.proto.File.*;
import adapter.converter.itemProto.ConverterItem;
import adapter.converter.itemTypeProto.ConverterItemType;
import adapter.converter.userProto.ConverterUser;

import java.util.ArrayList;

public class ConverterShelf
{

  public static ShelfProto shelf_to_ShelfProto(Shelf shelf)
  {
    ArrayList<ItemProto> itemProtos = new ArrayList<>();

    ShelfProto result=ShelfProto.newBuilder()
        .setRowNo(shelf.getRowNo())
        .setShelfNo(shelf.getShelfNo())
        .setShelfDimX(shelf.getDimX())
        .setShelfDimY(shelf.getDimY())
        .setShelfDimZ(shelf.getDimZ())
        .addAllItemsOnShelf(itemProtos)
        .build();


    for (Item item : shelf.getItemsOnShelf())
    {
      itemProtos.add(ItemProto.newBuilder()
          .setType(ConverterItemType.itemType_To_ItemTypeProto(item.getType()))
          .setUniqueID(item.getUid())
          .setOwner(ConverterUser.User_To_UserProto(item.getOwner()))
          .setShelf(result).build());


    }


    return result;
  }
}
