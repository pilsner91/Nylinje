package Domain.Model;

public class Item {

    private ItemType type;
    private int Uid;
    private User Owner;
    private Shelf shelf;


    public Item(ItemType type, int uid, User owner, Shelf shelf) {
        this.type = type;
        Uid = uid;
        Owner = owner;
        this.shelf = shelf;
    }

    public ItemType getType() {
        return type;
    }

    public void setType(ItemType type) {
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
