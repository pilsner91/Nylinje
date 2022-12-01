package database.DaoInterface;

import Domain.Model.Item;

public interface IItemDao {
    public Item Create(Item dto);
    public Item Read(String dto);
    public Item Update(Item dto);
    /*public Item Remove(ItemDeleteRequest dto);*/

}
