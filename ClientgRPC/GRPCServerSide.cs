// See https://aka.ms/new-console-template for more information


using Grpc.Net.Client;
using GRPC.Proto;

namespace ClientgRPC;

public class GRPCServerSide{
    




    async Task<ShelfProto> GetShelf(ShelfSearchRequest search)
    {
        var _channel = GrpcChannel.ForAddress("http://localhost:9090");
        var _shelvesClient = new Serivces.SerivcesClient(_channel);
        ShelfProto shelfProto = await _shelvesClient.getShelfAsync(search);
        return shelfProto;
    }


    async Task<ItemProto> GetItem(ItemSearchRequest search)
    {
        var _channel = GrpcChannel.ForAddress("http://localhost:9090");
        var _itemClient = new Serivces.SerivcesClient(_channel);
        ItemProto itemProto = await _itemClient.ReadItemAsync(search);
        return itemProto;
    }

    public async Task<ItemTypeProto> CreateItemTypeGRPC(ItemTypeCreationRequest dao)
    {
        var _channel = GrpcChannel.ForAddress("http://localhost:9090");
        var _itemType = new Serivces.SerivcesClient(_channel);
        ItemTypeProto itemTypeProto = await _itemType.CreateItemTypeAsync(dao);
        return itemTypeProto;
    }

    public async Task<ItemTypeProto> SearchItemTypeGRPC(ItemTypeSearchRequest dao)
    {
        var _channel = GrpcChannel.ForAddress("http://localhost:9090");
        var _itemType = new Serivces.SerivcesClient(_channel);
        ItemTypeProto itemTypeProto = await _itemType.ReadItemTypeAsync(dao);
        return itemTypeProto;   
    }

    public async Task<ItemProto> CreateItemGRPCAsync(ItemCreation dao)
    {
        var _channel = GrpcChannel.ForAddress("http://localhost:9090");
        var _item = new Serivces.SerivcesClient(_channel);
        ItemProto itemProto = await _item.CreateItemAsync(dao);
        return itemProto;   
    }

    public async Task<ItemProto> GetItemGRPCAsync(ItemSearchRequest dao)
    {
        var _channel = GrpcChannel.ForAddress("http://localhost:9090");
        var _item = new Serivces.SerivcesClient(_channel);
        ItemProto itemProto = await _item.ReadItemAsync(dao);
        return itemProto;    
    }

    public async Task<ItemProto> DeleteItemGRPCAsync(ItemSearchRequest dao)
    {
        var _channel = GrpcChannel.ForAddress("http://localhost:9090");
        var _item = new Serivces.SerivcesClient(_channel);
        ItemProto itemProto = await _item.DeleteItemAsync(dao);
        return itemProto;
    }


    public async Task<ShelfProto> ReadShelfAsync(ShelfSearchRequest dao)
    {
        var _channel = GrpcChannel.ForAddress("http://localhost:9090");
        var _shelf = new Serivces.SerivcesClient(_channel);
        ShelfProto shelfProto = await _shelf.getShelfAsync(dao);
        return shelfProto;
    }

    public async Task<ShelfProto> UpdateSelfAsync(ShelfProto dao)
    {
        var _channel = GrpcChannel.ForAddress("http://localhost:9090");
        var _shelf = new Serivces.SerivcesClient(_channel);
        ShelfProto shelfProto = await _shelf.UpdateShelfAsync(dao);
        return shelfProto;
    }

}