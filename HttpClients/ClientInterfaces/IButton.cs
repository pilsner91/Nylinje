using Shared.Model;

namespace HttpClients.ClientInterfaces;

public interface IButton
{

   public Task<Item> Reserver();
}