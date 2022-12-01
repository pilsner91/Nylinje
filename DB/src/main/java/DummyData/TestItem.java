package DummyData;

import Domain.Dto.ItemCreateDto;
import Domain.Model.Item;
import Domain.Model.ItemType;
import Domain.Model.Shelf;
import Domain.Model.User;
import database.DaoInterface.IItemDao;

import java.util.ArrayList;

public class TestItem implements IItemDao {
    @Override
    public Item Create(ItemCreateDto dto) {
        return new Item(new ItemType(1,2.,3.,4.),3,new User(2),new Shelf("st","std",1.,2.,3., new ArrayList<Item>()));
    }

    @Override
    public Item Read(String dto) {
        return null;
    }

    @Override
    public Item Update(Item dto) {
        return null;
    }
}
