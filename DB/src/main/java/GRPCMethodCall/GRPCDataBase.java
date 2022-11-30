/*
package GRPCMethodCall;

import Domain.Model.User;
import GRPC.proto.File;
import adapter.Shelf.GetShelfAdapterDB;
import adapter.User.CreateUserAdapterDB;
import database.DAOs.UserDao;

import java.sql.SQLException;

public class GRPCDataBase implements IGRPCDataBase {

    @Override
    public File.ShelfProto ReadShelf(File.ShelfSearchRequest dao) {
        GetShelfAdapterDB shelfSelect = new GetShelfAdapterDB();
        File.ShelfProto shelfRespond = null;

        shelfRespond = GetShelfAdapterDB.shelfResponse(dao);

        return shelfRespond;
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
