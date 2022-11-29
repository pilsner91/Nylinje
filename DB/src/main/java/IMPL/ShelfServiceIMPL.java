package IMPL;

import GRPC.proto.File;
import GRPC.proto.SerivceGrpc;
import GRPC.shelf.SearchShelfParametersProto;
import GRPC.shelf.ShelfProto;
import GRPC.shelf.ShelvesGrpc;
import io.grpc.stub.StreamObserver;


public class ShelfServiceIMPL extends SerivceGrpc.SerivceImplBase
{
    @Override
    public void getShelf(File.ShelfSearchRequest itemRequest,
                         StreamObserver<File.Shelf> itemResponds)
    {





        itemResponds.onCompleted();
    }



}


