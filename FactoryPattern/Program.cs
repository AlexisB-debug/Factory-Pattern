namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create a treasure!");
            string treasure = TreasureDoWhileLoop();
            
            var find = Excavate.CreateFind(treasure);
            find.Unearth();

            static string TreasureDoWhileLoop()
            {
                string treasure;
                // string artifact = "artifact";
                // string fossil = "fossil";
                // string ore = "ore";

                do
                {
                    Console.WriteLine("Please, type the word 'artifact', 'fossil', or 'ore'");
                    treasure = Console.ReadLine().ToLower();
                }while(treasure != "artifact" && treasure != "fossil" && treasure != "ore");
                return treasure;
            }
        }
    }
}
