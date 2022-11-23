namespace Shared.Model; 

public class itemType {

    public int Id { get; set; }
    public double DimX { get; set; }
    public double DimY { get; set; }
    public double DimZ { get; set; }

    public itemType(int id, double dimX, double dimY, double dimZ)
    {
        Id = id;
        DimX = dimX;
        DimY = dimY;
        DimZ = dimZ;
    }
}