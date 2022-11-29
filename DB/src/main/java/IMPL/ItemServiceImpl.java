package IMPL;



import GRPC.proto.File;
import GRPC.proto.SerivceGrpc;
import GRPCMethodCall.IGRPCDataBase;
import io.grpc.stub.StreamObserver;

public class ItemServiceImpl extends SerivceGrpc.SerivceImplBase {
/*
    public void getItems(SearchItemsParametersProto itemRequest, StreamObserver<ItemProto> itemResponds){
        ItemTypeProto typeProto = ItemTypeProto.newBuilder()
                .setDimensionX(2).setDimensionY(2)
                .setDimensionZ(2).setId(2).build();

        ItemProto itemPrto = ItemProto.newBuilder()
                .setId(2).setShelfId(2)
                .setType(typeProto).build();


        itemResponds.onNext(itemPrto);
        itemResponds.onCompleted();
    }

*/

}

