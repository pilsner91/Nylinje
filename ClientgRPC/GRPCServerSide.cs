// See https://aka.ms/new-console-template for more information

using GRPC.Item;
using Grpc.Net.Client;

public class GRPCServerSide{
    

private SearchShelfParametersProto _shelfParametersProto = new SearchShelfParametersProto {Id = 1};
private SearchItemsParametersProto _itemsParametersProto = new SearchItemsParametersProto { Id = 1 };

private var _channel = GrpcChannel.ForAddress("http://localhost:9090");
private var _shelvesClient = new Shelves.ShelvesClient(_channel);
private var _itemClient = new Items.ItemsClient(_channel);
private var _proto = new Service

async Task<ShelfProto> GetShelf(SearchShelfParametersProto search)
{
    ShelfProto shelfProto = await _shelvesClient.GetShelfAsync(search);
    return shelfProto;
}
ShelfProto _shelfProto = await GetShelf(_shelfParametersProto);


async Task<ItemProto> GetItem(SearchItemsParametersProto search)
{
    ItemProto itemProto = await _itemClient.GetItemsAsync(search);
    return itemProto;
}

ItemProto _itemProto = await GetItem(_itemsParametersProto);




Console.WriteLine(_shelfProto.RowNo);
Console.WriteLine(_itemProto.Id);
}
