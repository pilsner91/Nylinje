package adapter.ItemType;


import Domain.Model.itemType;
import GRPC.proto.File;
import database.DaoInterface.IItemTypeDao;

public class CreateItemTypeAdapterDB {
    private IItemTypeDao iItemTypeDao;

    public CreateItemTypeAdapterDB(IItemTypeDao iItemTypeDao) {
        this.iItemTypeDao = iItemTypeDao;
    }

    public File.ItemTypeProto CreateItemType(File.ItemTypeProto itemTypProto){

        itemType typeOfItem = new itemType(
                itemTypProto.getId(),
                itemTypProto.getDimX(),
                itemTypProto.getDimY(),
                itemTypProto.getDimZ());

        itemType result =iItemTypeDao.Create(typeOfItem);



        File.ItemTypeProto newItemTypeProto = File.ItemTypeProto.newBuilder()
                .setId(result.getId())
                .setDimX(result.getDimX())
                .setDimY(result.getDimY())
                .setDimZ(result.getDimZ())
                .build();
        ;

        return newItemTypeProto;
    }


}
