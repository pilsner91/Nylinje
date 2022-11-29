// See https://aka.ms/new-console-template for more information

using GRPC.Item;
using Grpc.Net.Client;
using GRPC.General;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.AspNetCore.StaticFiles.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

public class GRPCServerSide{
    

private SearchShelfParametersProto _shelfParametersProto = new SearchShelfParametersProto {Id = 1};
private SearchItemsParametersProto _itemsParametersProto = new SearchItemsParametersProto { Id = 1 };



async Task<ShelfProto> GetShelf(SearchShelfParametersProto search)
{
    var _channel = GrpcChannel.ForAddress("http://localhost:9090");
    var _shelvesClient = new Shelves.ShelvesClient(_channel);
    ShelfProto shelfProto = await _shelvesClient.GetShelfAsync(search);
    return shelfProto;
}


async Task<ItemProto> GetItem(SearchItemsParametersProto search)
{
var _channel = GrpcChannel.ForAddress("http://localhost:9090");
var _itemClient = new Items.ItemsClient(_channel);
    ItemProto itemProto = await _itemClient.GetItemsAsync(search);
    return itemProto;
}

public async Task<ItemType> CreateItemTypeGRPC(ItemTypeCreationRequest dao)
{
    var _channel = GrpcChannel.ForAddress("http://localhost:9090");
    var _itemType = new Serivces.SerivcesClient(_channel);
    ItemType itemTypeProto = await _itemType.CreateItemTypeAsync(dao);
    return itemTypeProto;
}

public async Task<ItemType> SearchItemTypeGRPC(ItemTypeSearchRequest dao)
{
    var _channel = GrpcChannel.ForAddress("http://localhost:9090");
    var _itemType = new Serivces.SerivcesClient(_channel);
    ItemType itemTypeProto = await _itemType.ReadItemTypeAsync(dao);
    return itemTypeProto;   
}

public async Task<Item> CreateItemGRPCAsync(ItemCreation dao)
{
    var _channel = GrpcChannel.ForAddress("http://localhost:9090");
    var _item = new Serivces.SerivcesClient(_channel);
    Item itemProto = await _item.CreateItemAsync(dao);
    return itemProto;   
}

public async Task<Item> GetItemGRPCAsync(ItemSearchRequest dao)
{
    var _channel = GrpcChannel.ForAddress("http://localhost:9090");
    var _item = new Serivces.SerivcesClient(_channel);
    Item itemProto = await _item.ReadItemAsync(dao);
    return itemProto;    
}

public async Task<Item> DeleteItemGRPCAsync(ItemSearchRequest dao)
{
    var _channel = GrpcChannel.ForAddress("http://localhost:9090");
    var _item = new Serivces.SerivcesClient(_channel);
    Item itemProto = await _item.DeleteItemAsync(dao);
    return itemProto;
}


public async Task<Shelf> ReadShelfAsync(ShelfSearchRequest dao)
{
    var _channel = GrpcChannel.ForAddress("http://localhost:9090");
    var _shelf = new Serivces.SerivcesClient(_channel);
    Shelf shelfProto = await _shelf.getShelfAsync(dao);
    return shelfProto;
}

public async Task<Shelf> UpdateSelfAsync(Shelf dao)
{
    var _channel = GrpcChannel.ForAddress("http://localhost:9090");
    var _shelf = new Serivces.SerivcesClient(_channel);
    Shelf shelfProto = await _shelf.UpdateShelfAsync(dao);
    return shelfProto;
}

}
