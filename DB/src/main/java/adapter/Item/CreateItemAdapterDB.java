package adapter.Item;

import Domain.Model.Item;
import GRPC.proto.File.*;
import adapter.converter.ShelfProto.ConverterShelf;
import adapter.converter.itemProto.ConverterItem;
import adapter.converter.itemTypeProto.ConverterItemType;
import adapter.converter.userProto.ConverterUser;
import database.DaoInterface.IItemDao;

public class CreateItemAdapterDB {
    private IItemDao iItemDao;

    public CreateItemAdapterDB(IItemDao iItemDao)
    {
        this.iItemDao = iItemDao;
    }

    public ItemProto CreateItemProto(ItemProto itemProto)
    {
        Item item = ConverterItem.itemProto_to_Item(itemProto);


        Item result = iItemDao.Create(item);


        return ConverterItem.item_To_ItemProto(result);
    }


}
