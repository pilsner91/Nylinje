package GRPCMethodCall;

import GRPC.proto.File;

public interface IGRPCDataBase {

    File.Shelf ReadShelf(File.ShelfSearchRequest dao);
    File.Shelf UpdateShelf(File.Shelf dao);

    File.ItemType CreateItemType(File.ItemTypeCreationRequest dao);
    File.ItemType ReadItem(File.ItemTypeSearchRequest dao);

    File.Item CreateItem(File.ItemCreation dao);
    File.Item ReadItem(File.ItemSearchRequest dao);
    File.Item DeleteItem(File.ItemSearchRequest dao);

    File.User CreateUser(File.User dao);



}
