// See https://aka.ms/new-console-template for more information

using Grpc.Net.Client;
using GRPC.Shelf;

SearchShelfParametersProto shelfParametersProto = new SearchShelfParametersProto {Id = 1};

using var channel = GrpcChannel.ForAddress("http://localhost:9090");
var client = new Shelves.ShelvesClient(channel);


async Task<ShelfProto> GetShelf(SearchShelfParametersProto search)
{
    ShelfProto shelfProto = await client.GetShelfAsync(search);
    return shelfProto;
}

ShelfProto shelfProto = await GetShelf(shelfParametersProto);
Console.WriteLine(shelfProto.RowNo);
Console.WriteLine("hello");
