// See https://aka.ms/new-console-template for more information

namespace src
{
    class EntryClass
    {
        public static void Main()
        {
            Console.WriteLine("running");
            foreach (TileTemplate tileTemplate in new ParsingUtil().GetTileTemplates())
            {
                Console.WriteLine(tileTemplate);
            }
        }
    }
}