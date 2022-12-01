package Domain.Dto;

import Domain.Model.ItemType;
import Domain.Model.Shelf;
import Domain.Model.User;

public class ItemCreateDto {
    private int type;

    private int Owner;
    private int shelf;


    public ItemCreateDto(int type, int owner, int shelf) {
        this.type = type;
        Owner = owner;
        this.shelf = shelf;
    }

    public int getType() {
        return type;
    }

    public void setType(int type) {
        this.type = type;
    }


    public int getOwner() {
        return Owner;
    }

    public void setOwner(int owner) {
        Owner = owner;
    }

    public int getShelf() {
        return shelf;
    }

    public void setShelf(int shelf) {
        this.shelf = shelf;
    }
}
