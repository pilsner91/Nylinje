package GRPCMethodCall;

import GRPC.proto.File;

public interface IGRPCDataBase {

    File.Shelf GetShelf(File.ShelfSearchRequest dao);

    File.Shelf UpdateShelf(File.Shelf dao);

    File.Item CreateItem(File.Item)
}
