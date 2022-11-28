// See https://aka.ms/new-console-template for more information

using GRPC.Item;
using Grpc.Net.Client;
using GRPC.General;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
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

}
