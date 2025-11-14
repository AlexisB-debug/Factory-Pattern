namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create a treasure!");
            string treasure = TreasureDoWhileLoop();
            
            var remnant = FindFactory.GetFind(treasure);
            remnant.Unearth();

            static string TreasureDoWhileLoop()
            {
                string treasure;

                do
                {
                    Console.WriteLine("Please, type the word 'artifact', 'fossil', or 'mineral'");
                    treasure = Console.ReadLine().ToLower();
                }while(treasure != "artifact" && treasure != "fossil" && treasure != "mineral");
                return treasure;
            }
        }
    }
}
