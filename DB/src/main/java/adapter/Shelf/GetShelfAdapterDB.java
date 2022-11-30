package adapter.Shelf;

import Domain.Model.Item;
import Domain.Model.Shelf;
import GRPC.proto.File.*;
import database.DaoInterface.IShelfDao;
import java.util.ArrayList;


public class GetShelfAdapterDB {

    private IShelfDao iShelfDao;

    public GetShelfAdapterDB(IShelfDao dao) {
        this.iShelfDao = dao;
    }

    public ShelfProto shelfResponse(ShelfSearchRequest shelfProto)
    {
        Shelf result = iShelfDao.Read(shelfProto.getId());
        ArrayList<Item> itemResponses;
return null;
    }
}
