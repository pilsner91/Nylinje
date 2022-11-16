// See https://aka.ms/new-console-template for more information

using Grpc.Net.Client;
using Shelf;


SearchShelfParametersProto shelfParametersProto = new SearchShelfParametersProto();

shelfParametersProto.Id = 1;

using var channel = GrpcChannel.ForAddress("http://localhost:9090");
var client = new Shelves.ShelvesClient(channel);


async Task<Shelf.Shelf> GetShelf(SearchShelfParametersProto search)
{
    return await client.GetShelfAsync(search);
}

Console.WriteLine(GetShelf(shelfParametersProto));

Console.WriteLine("BOOOOOBBB");