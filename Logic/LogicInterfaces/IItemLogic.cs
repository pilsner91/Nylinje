using Shared.DTOs;


namespace Logic.LogicInterfaces; 

public interface IItemLogic {
    Task<Shared.Model.Item> CreateAsync(ItemCreationDto dto);
}