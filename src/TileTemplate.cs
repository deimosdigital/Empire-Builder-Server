namespace src;

public class TileTemplate
{
    // public TileTemplate(string name, int spawnWeight)
    // {
    //     Name = name;
    //     SpawnWeight = spawnWeight;
    // }
    public string Name { get; set; }
    public int SpawnWeight { get; set; }

    public override string ToString()
    {
        return $"{Name}";
    }
}