package adapter.ItemType;


import Domain.Model.ItemType;
import GRPC.proto.File;
import adapter.converter.itemTypeProto.ConverterItemType;
import database.DaoInterface.IItemTypeDao;

public class CreateItemTypeAdapterDB {
    private IItemTypeDao iItemTypeDao;

    public CreateItemTypeAdapterDB(IItemTypeDao iItemTypeDao) {
        this.iItemTypeDao = iItemTypeDao;
    }


    public File.ItemTypeProto CreateItemType(File.ItemTypeProto itemTypProto){

        ItemType typeOfItem = ConverterItemType.itemTypeProto_To_ItemType(itemTypProto);

        ItemType result = iItemTypeDao.Create(typeOfItem);

        return ConverterItemType.itemType_To_ItemTypeProto(result);
    }


}
