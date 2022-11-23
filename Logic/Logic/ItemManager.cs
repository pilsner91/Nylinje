using Logic.LogicInterfaces;
using Shared.DTOs;
using Shared.Model;

namespace Logic.Logic; 

public class ItemManager : IItemLogic, IItemManager {
    public async Task<Shared.Model.Item>  CreateAsync(ItemCreationDto dto) {
        throw new NotImplementedException();
    }

    public async Task<itemType> createItemAsync(ItemTypeCreationDto dto)
    {
        throw new NotImplementedException();
    }
}