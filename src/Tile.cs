using System.Drawing;

namespace src;

public abstract class Tile
{
    public Point location;
    public int owner_id;
    public string type;
    public int country_id;

    public override int GetHashCode()
    {
        return location.GetHashCode();
    }
}