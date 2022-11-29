package Domain.Model;

public class itemType {
    private int id;
    private Double dimX;
    private Double dimY;
    private Double dimZ;

    public itemType(int id, Double dimX, Double dimY, Double dimZ) {
        this.id = id;
        this.dimX = dimX;
        this.dimY = dimY;
        this.dimZ = dimZ;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public Double getDimX() {
        return dimX;
    }

    public void setDimX(Double dimX) {
        this.dimX = dimX;
    }

    public Double getDimY() {
        return dimY;
    }

    public void setDimY(Double dimY) {
        this.dimY = dimY;
    }

    public Double getDimZ() {
        return dimZ;
    }

    public void setDimZ(Double dimZ) {
        this.dimZ = dimZ;
    }
}


