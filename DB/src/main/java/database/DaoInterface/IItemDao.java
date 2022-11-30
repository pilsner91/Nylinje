package database.DaoInterface;

import Domain.Model.Item;
import GRPC.proto.File.*;

public interface IItemDao {
    /*public File.Item Create(ItemCreate dto);*/
    public Item Read(String dto);
    public Item Update(Item dto);
    /*public Item Remove(ItemDeleteRequest dto);*/

}
