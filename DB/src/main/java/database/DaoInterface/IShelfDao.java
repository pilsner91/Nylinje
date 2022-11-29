package database.DaoInterface;


import GRPC.proto.File.*;

import java.sql.ResultSet;

public interface IShelfDao {
    /*public File.Shelf Create(File.ShelfCreateRequest dto);*/
    public Domain.Model.Shelf Read(int read);
    public Shelf Update(ShelfSearchRequest dto);
    /*public File.Shelf Remove(File.ShelfSearchRequest dto);*/
}
