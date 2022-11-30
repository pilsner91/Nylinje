package database.DaoInterface;

import Domain.Model.itemType;
import GRPC.proto.File.*;

public interface IItemTypeDao {
    itemType Create(itemType dto);
    itemType Read(int dto);
    itemType Update(itemType itemType);
    /*public ItemType Remove(ItemTypeDeleteRequest dto);*/
}
