using System.Drawing;

namespace src;

public class Map
{
    // private Random random;
    // private List<TileTemplate> templates;
    //
    // private Dictionary<Point, Tile> tiles = new();
    //
    // Map(List<TileTemplate> templates)
    // {
    //     this.templates = templates;
    //     random = new Random();
    // }
    //
    // public TileTemplate GetRandomTemplate()
    // {
    //     int totalWeight = 0;
    //     foreach (TileTemplate tile in templates)
    //     {
    //         totalWeight += tile.spawn_weight;
    //     }
    //
    //     double choice = random.NextDouble();
    //
    //     double currentFrac = 0;
    //     foreach (TileTemplate tile in templates)
    //     {
    //         currentFrac += (double)tile.spawn_weight / totalWeight;
    //         if (choice <= currentFrac)
    //         {
    //             return tile;
    //         }
    //     }
    //     return templates.Last();
    // }
}