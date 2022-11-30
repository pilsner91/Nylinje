package database.DaoInterface;

import Domain.Model.ItemType;

public interface IItemTypeDao {
    ItemType Create(ItemType dto);
    ItemType Read(int dto);
    ItemType Update(ItemType itemType);
    /*public ItemType Remove(ItemTypeDeleteRequest dto);*/
}
