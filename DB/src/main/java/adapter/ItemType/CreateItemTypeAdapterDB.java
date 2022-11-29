package adapter.ItemType;

import GRPC.proto.File;
import database.DaoInterface.IItemDao;
import database.DaoInterface.IItemTypeDao;

public class CreateItemTypeAdapterDB {
    private IItemTypeDao iItemTypeDao;
    public File.ItemType CreateItem(File.ItemType itemType){

        return File.ItemType.newBuilder()
                .setId(itemType.getId())
                .setDimX(itemType.getDimX())
                .setDimY(itemType.getDimY())
                .setDimZ(itemType.getDimZ())
                .build();
    }
}
