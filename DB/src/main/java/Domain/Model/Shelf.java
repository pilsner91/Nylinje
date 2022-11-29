package Domain.Model;

import java.util.ArrayList;

public class Shelf {
    private String RowNo;
    private String ShelfNo;
    private double dimX;
    private double dimY;
    private double dimZ;
    private ArrayList<Item> ItemsOnShelf;

    public Shelf(String rowNo, String shelfNo, double dimX, double dimY, double dimZ, ArrayList<Item> itemsOnShelf) {
        RowNo = rowNo;
        ShelfNo = shelfNo;
        this.dimX = dimX;
        this.dimY = dimY;
        this.dimZ = dimZ;
        ItemsOnShelf = itemsOnShelf;
    }

    public String getRowNo() {
        return RowNo;
    }

    public void setRowNo(String rowNo) {
        RowNo = rowNo;
    }

    public String getShelfNo() {
        return ShelfNo;
    }

    public void setShelfNo(String shelfNo) {
        ShelfNo = shelfNo;
    }

    public double getDimX() {
        return dimX;
    }

    public void setDimX(double dimX) {
        this.dimX = dimX;
    }

    public double getDimY() {
        return dimY;
    }

    public void setDimY(double dimY) {
        this.dimY = dimY;
    }

    public double getDimZ() {
        return dimZ;
    }

    public void setDimZ(double dimZ) {
        this.dimZ = dimZ;
    }

    public ArrayList<Item> getItemsOnShelf() {
        return ItemsOnShelf;
    }

    public void setItemsOnShelf(ArrayList<Item> itemsOnShelf) {
        ItemsOnShelf = itemsOnShelf;
    }
}
