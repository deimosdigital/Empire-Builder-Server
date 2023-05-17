using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace src;

class ParsingUtil
{
    public List<TileTemplate> GetTileTemplates()
    {
        var deserializer = new DeserializerBuilder()
            // .WithNamingConvention(PascalCaseNamingConvention.Instance) // Use the underscore convention
            .Build();

        string yaml = File.ReadAllText("tile_templates.yml");

        var tiles = deserializer.Deserialize<List<TileTemplate>>(yaml);

        // foreach (var person in people)
        // {
        //     Console.WriteLine($"{person.Name}, {person.Age}, {person.Email}");
        // }
        return tiles;
    }

   
}