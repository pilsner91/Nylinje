package IMPL;

import GRPC.item.*;
import GRPC.shelf.SearchShelfParametersProto;
import GRPC.shelf.ShelfProto;
import io.grpc.stub.StreamObserver;

public class ItemServiceImpl extends ItemsGrpc.ItemsImplBase {

    public void getItem(SearchItemsParametersProto itemRequest, StreamObserver<ItemProto> itemResponds){
        ItemTypeProto typeProto = ItemTypeProto.newBuilder().setDimensionX(2).setDimensionY(2).setDimensionZ(2).setId(2).build();
        ItemProto itemPrto = ItemProto.newBuilder().setId(2).setShelfId(2).setType(typeProto).build();    }

    public void getShelf(SearchShelfParametersProto request, StreamObserver<ShelfProto> response
    ){
        ShelfProto fisk = ShelfProto.newBuilder().setShelfNo("2").setDimensionX(2).setDimensionY(2).setDimensionZ(2).setRowNo("3").build();

    }






}
