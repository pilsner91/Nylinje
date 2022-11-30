/*
package GRPCMethodCall;

import Domain.Model.User;

import GRPC.proto.File;
import GRPC.proto.SerivceGrpc;
import adapter.Shelf.GetShelfAdapterDB;
import adapter.User.CreateUserAdapterDB;
import database.DAOs.UserDao;
import io.grpc.stub.StreamObserver;
import net.devh.boot.grpc.server.service.GrpcService;

@GrpcService
public class GRPCDataBase extends SerivceGrpc.SerivceImplBase {

    @Override
    public void getShelf(File.ShelfSearchRequest dao, StreamObserver<File.ShelfProto> itemResponds) {
        GetShelfAdapterDB shelfSelect = new GetShelfAdapterDB();
        File.ShelfProto shelfRespond = null;

        shelfRespond = GetShelfAdapterDB.shelfResponse(dao);

    }

    @Override
    public File.ShelfProto UpdateShelf(File.ShelfProto dao) {
        return null;
    }

    @Override
    public File.ItemTypeProto CreateItemType(File.ItemTypeCreationRequest dao) {
        return null;
    }

    @Override
    public File.ItemTypeProto ReadItem(File.ItemTypeSearchRequest dao) {
        return null;
    }

    @Override
    public File.ItemProto CreateItem(File.ItemCreation dao) {
        return null;
    }

    @Override
    public File.ItemProto ReadItem(File.ItemSearchRequest dao) {
        return null;
    }

    @Override
    public File.ItemProto DeleteItem(File.ItemSearchRequest dao) {
        return null;
    }

    @Override
    public File.UserProto CreateUser(File.UserProto dao) {
        CreateUserAdapterDB createUserAdapterDB = new CreateUserAdapterDB(null);
        File.UserProto userRespond = null;


        userRespond = createUserAdapterDB.CreateUser(dao);

        return userRespond;
    }
}
*/
