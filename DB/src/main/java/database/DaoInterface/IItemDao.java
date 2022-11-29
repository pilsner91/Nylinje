package database.DaoInterface;

import GRPC.proto.File.*;

public interface IItemDao {
    /*public File.Item Create(ItemCreate dto);*/
    public Item Read(String dto);
    public Item Update(Item dto);
    /*public Item Remove(ItemDeleteRequest dto);*/

}
