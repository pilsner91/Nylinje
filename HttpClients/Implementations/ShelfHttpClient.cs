using System.Text;
using System.Text.Json;
using HttpClients.ClientInterfaces;
using Shared.DTOs;
using Shared.Model;

namespace HttpClients.Implementations;

public class ShelfHttpClient : IShelfService
{
    private readonly HttpClient client;

    public ShelfHttpClient(HttpClient client)
    {
        this.client = client;
    }

    public async Task<bool> AddItemToShelf(List<ShelfAddItemRequestDto> dto)
    {
        string dtoAsJson = JsonSerializer.Serialize(dto);
        StringContent body = new StringContent(dtoAsJson, Encoding.UTF8, "application/json");

        HttpResponseMessage response = await client.PatchAsync("/shelf/AddItem", body);
        return true;
    }
}