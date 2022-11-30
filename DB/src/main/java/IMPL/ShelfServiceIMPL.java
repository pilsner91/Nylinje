package IMPL;

import GRPC.proto.File;
import GRPC.proto.SerivceGrpc;
import GRPCMethodCall.GRPCDataBase;
import GRPCMethodCall.IGRPCDataBase;
import io.grpc.stub.StreamObserver;



public class ShelfServiceIMPL extends SerivceGrpc.SerivceImplBase
{
    @Override
    public void getShelf(File.ShelfSearchRequest itemRequest,
                         StreamObserver<File.Shelf> itemResponds)
    {
        IGRPCDataBase converter = new GRPCDataBase() {


        };





    }



}


