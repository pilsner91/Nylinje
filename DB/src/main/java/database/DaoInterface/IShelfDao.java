package database.DaoInterface;

import Domain.Model.Shelf;
import GRPC.proto.File.*;

import java.sql.ResultSet;

public interface IShelfDao {
    /*public File.Shelf Create(File.ShelfCreateRequest dto);*/
    public Shelf Read(int read);
    public Shelf Update(ShelfSearchRequest dto);
    /*public File.Shelf Remove(File.ShelfSearchRequest dto);*/
}
