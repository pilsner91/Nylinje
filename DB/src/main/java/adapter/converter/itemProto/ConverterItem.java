package adapter.converter.itemProto;

import Domain.Model.Item;
import GRPC.proto.File.*;
import adapter.converter.ShelfProto.ConverterShelf;
import adapter.converter.itemTypeProto.ConverterItemType;
import adapter.converter.userProto.ConverterUser;
import database.DaoInterface.IItemDao;

public class ConverterItem
{
  public static ItemProto item_To_ItemProto(Item item)
  {
    return ItemProto.newBuilder()
        .setType(ConverterItemType.itemType_To_ItemTypeProto(item.getType()))
        .setUniqueID(item.getUid())
        .setOwner(ConverterUser.User_To_UserProto(item.getOwner()))
        .setShelf(ConverterShelf.shelf_to_ShelfProto(item.getShelf()))
        .build();
  }
}





