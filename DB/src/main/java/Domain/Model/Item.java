package Domain.Model;

public class Item {

    private itemType type;
    private int Uid;
    private User Owner;
    private Shelf shelf;


    public Item(itemType type, int uid, User owner, Shelf shelf) {
        this.type = type;
        Uid = uid;
        Owner = owner;
        this.shelf = shelf;
    }

    public itemType getType() {
        return type;
    }

    public void setType(itemType type) {
        this.type = type;
    }

    public int getUid() {
        return Uid;
    }

    public void setUid(int uid) {
        Uid = uid;
    }

    public User getOwner() {
        return Owner;
    }

    public void setOwner(User owner) {
        Owner = owner;
    }

    public Shelf getShelf() {
        return shelf;
    }

    public void setShelf(Shelf shelf) {
        this.shelf = shelf;
    }
}
