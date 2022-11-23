using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using HttpClients.ClientInterfaces;
using Shared.DTOs;
using Shared.Model;


namespace HttpClients.Implementations;

public class ItemTypeHttpClient : IItemTypeService
{
    private HttpClient client;

    public ItemTypeHttpClient(HttpClient client) {
        this.client = client;
    }
    public async Task<itemType> CreateAsync(ItemTypeCreationDto dto)
    {
        HttpResponseMessage response = await client.PostAsJsonAsync("/itemsType", dto);
        string result = await response.Content.ReadAsStringAsync();
        
        if (!response.IsSuccessStatusCode)
        {
            
            throw new Exception(result);
        }

        itemType itemType = JsonSerializer.Deserialize<itemType>(result, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        })!;
        return itemType;
    }

}