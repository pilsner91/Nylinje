package GRPCMethodCall;

import GRPC.proto.File;

public interface IGRPCDataBase {

    File.ShelfProto ReadShelf(File.ShelfSearchRequest dao);
    File.ShelfProto UpdateShelf(File.ShelfProto dao);

    File.ItemTypeProto CreateItemType(File.ItemTypeCreationRequest dao);
    File.ItemTypeProto ReadItem(File.ItemTypeSearchRequest dao);

    File.ItemTypeProto CreateItem(File.ItemCreation dao);
    File.ItemTypeProto ReadItem(File.ItemSearchRequest dao);
    File.ItemTypeProto DeleteItem(File.ItemSearchRequest dao);

    File.UserProto CreateUser(File.UserProto dao);



}
