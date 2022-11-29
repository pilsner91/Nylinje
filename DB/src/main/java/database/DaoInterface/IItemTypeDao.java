package database.DaoInterface;

import GRPC.proto.File.*;

public interface IItemTypeDao {
    public ItemType Create(ItemTypeCreationRequest dto);
    public ItemType Read(ItemTypeSearchRequest dto);
    public ItemType Update(ItemType itemType);
    /*public ItemType Remove(ItemTypeDeleteRequest dto);*/
}
