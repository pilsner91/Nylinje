package database.DaoInterface;

import Domain.Model.Shelf;
import GRPC.proto.File.*;

import java.sql.ResultSet;

public interface IShelfDao {
    public Shelf Create(Shelf dto);
    public Shelf Read(int read);
    public Shelf Update(Shelf dto);
    /*public File.Shelf Remove(File.ShelfSearchRequest dto);*/
}
