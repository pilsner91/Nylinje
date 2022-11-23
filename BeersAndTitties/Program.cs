// See https://aka.ms/new-console-template for more information

using Grpc.Net.Client;
using GRPC.Item;





SearchShelfParametersProto shelfParametersProto = new SearchShelfParametersProto {Id = 1};
SearchItemsParametersProto itemsParametersProto = new SearchItemsParametersProto { Id = 1 };


using var channel = GrpcChannel.ForAddress("http://localhost:9090");
var shelvesClient = new Shelves.ShelvesClient(channel);
var itemClient = new Items.ItemsClient(channel);





async Task<ShelfProto> GetShelf(SearchShelfParametersProto search)
{
    ShelfProto shelfProto = await shelvesClient.GetShelfAsync(search);
    return shelfProto;
}
ShelfProto shelfProto = await GetShelf(shelfParametersProto);


async Task<ItemProto> GetItem(SearchItemsParametersProto search)
{
    ItemProto itemProto = await itemClient.GetItemsAsync(search);
    return itemProto;
}

ItemProto itemProto = await GetItem(itemsParametersProto);




Console.WriteLine(shelfProto.RowNo);
Console.WriteLine(itemProto.Id);


