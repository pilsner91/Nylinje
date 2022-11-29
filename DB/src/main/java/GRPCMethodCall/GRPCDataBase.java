package GRPCMethodCall;

import Domain.Model.User;
import GRPC.proto.File;
import adapter.Shelf.GetShelfAdapterDB;
import adapter.User.CreateUserAdapterDB;

import java.sql.SQLException;

public class GRPCDataBase implements IGRPCDataBase {

    @Override
    public File.Shelf ReadShelf(File.ShelfSearchRequest dao) {
        GetShelfAdapterDB shelfSelect = new GetShelfAdapterDB();
        File.Shelf shelfRespond = null;

        shelfRespond = GetShelfAdapterDB.shelfResponse(dao);

        return shelfRespond;
    }

    @Override
    public File.Shelf UpdateShelf(File.Shelf dao) {
        return null;
    }

    @Override
    public File.ItemType CreateItemType(File.ItemTypeCreationRequest dao) {
        return null;
    }

    @Override
    public File.ItemType ReadItem(File.ItemTypeSearchRequest dao) {
        return null;
    }

    @Override
    public File.Item CreateItem(File.ItemCreation dao) {
        return null;
    }

    @Override
    public File.Item ReadItem(File.ItemSearchRequest dao) {
        return null;
    }

    @Override
    public File.Item DeleteItem(File.ItemSearchRequest dao) {
        return null;
    }

    @Override
    public File.User CreateUser(File.User dao) {
        CreateUserAdapterDB createUserAdapterDB = new CreateUserAdapterDB();
        File.User userRespond = null;


        userRespond = createUserAdapterDB.CreateUser(dao);

        return userRespond;
    }
}
