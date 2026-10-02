using System.Security.Cryptography.X509Certificates;
using System.Transactions;

public class PositionOrientation
{
    public int xCoords;
    public int yCoords;
    public string currentDirection;

    public int xPosition(int xUpdate)
    {
        
        xCoords += xUpdate;
        return xCoords;
    }

    public int yPosition(int yUpdate)
    {
        yCoords += yUpdate;
        return yCoords;
    }
}