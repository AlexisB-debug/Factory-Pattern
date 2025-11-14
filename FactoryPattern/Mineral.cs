namespace FactoryPattern;

public class Mineral : IFind
{
    private string mineral = MineralDoWhileLoop();
    public void Unearth()
    {
        switch (mineral.ToLower())
        {
            case "gemstone":
                Console.WriteLine("The treasure is a rock.");
                Console.WriteLine($"Mining {GemstoneDoWhileLoop()}");
                break;
            case "ore":
                Console.WriteLine("Is the treasure ore.");
                Console.WriteLine($"Mining {OreDoWhileLoop()} ore");
                break;
            default: //"fool's gold"
                Console.WriteLine("Fool's Gold!");
                break;
        }
    }
    
    public static string MineralDoWhileLoop()
    {
        string mineral;

        do
        {
            Console.WriteLine("Please, type 'gemstone', 'ore', or 'fool's gold'");
            mineral = Console.ReadLine().ToLower();
        }while(mineral != "gemstone" && mineral != "ore" && mineral != "fool's gold");
        return mineral;
    }
    
    public string GemstoneDoWhileLoop()
    {
        string gemstone;
        
        do
        {
            Console.WriteLine("Please, type 'diamond', 'emerald', 'ruby', or 'sapphire'");
            gemstone = Console.ReadLine().ToLower();
        }while(gemstone != "diamond" && gemstone != "emerald" && gemstone != "ruby" && gemstone != "sapphire");
        return gemstone;
    }
    
    public string OreDoWhileLoop()
    {
        string ore;
        
        do
        {
            Console.WriteLine("Please, type 'copper', 'gold', 'iron', 'platinum' or 'silver'");
            ore = Console.ReadLine().ToLower();
        }while(ore != "copper" && ore != "gold" && ore != "iron" && ore != "platinum" && ore != "silver");
        return ore;
    }
}