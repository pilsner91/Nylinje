package adapter.Shelf;

import GRPC.proto.File.*;
import database.DaoInterface.IShelfDao;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;


public class GetShelfAdapterDB {

    private IShelfDao shelfConnector;

    public GetShelfAdapterDB(IShelfDao dao) {
        this.shelfConnector = dao;
    }

    public Shelf shelfResponse(ShelfSearchRequest shelfProto) throws SQLException
    {

        Domain.Model.Shelf shelfDomain = shelfConnector.Read(shelfProto.getId());
        ArrayList<Item> itemResponses;

        shelfDomain.


    }
}
