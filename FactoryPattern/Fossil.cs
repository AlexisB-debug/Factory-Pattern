namespace FactoryPattern;

public class Fossil : IFind
{
    private string fossil = FossilDoWhileLoop();
    public void Unearth()
    {
        switch (fossil.ToLower())
        {
            case "body fossil":
                Console.WriteLine("Is the treasure bones or shells?");
                Console.WriteLine($"Excavating {BodyFossilDoWhileLoop()}");
                break;
            case "trace fossil":
                Console.WriteLine("Is the treasure footprints or a fossilized nest?");
                Console.WriteLine($"{TraceFossilDoWhileLoop()}!");
                break;
            default: //"petrified fossil":
                Console.WriteLine("Is the treasure petrified wood, dinosaur egg, or Petoskey stones?");
                Console.WriteLine($"Petrified Fossils are beautiful! Look at the {PetrifiedFossilDoWhileLoop()}");
        }
    }

    public static string FossilDoWhileLoop()
    {
        string fossil;

        do
        {
            Console.WriteLine("Please, type 'body fossil', 'trace fossil', or 'petrified fossil'");
            fossil = Console.ReadLine().ToLower();
        }while(fossil != "body fossil" && fossil != "trace fossil" && fossil != "petrified fossil");
        return fossil;
    }
    
    public string BodyFossilDoWhileLoop()
    {
        string bodyFossil;
        
        do
        {
            Console.WriteLine("Please, type 'bones' or 'shells'");
            bodyFossil = Console.ReadLine().ToLower();
        }while(bodyFossil != "bones" && bodyFossil != "shells");
        return bodyFossil;
    }
    
    public string TraceFossilDoWhileLoop()
    {
        string traceFossil;
        
        do
        {
            Console.WriteLine("Please, type 'footprints' or 'fossilized nest'");
            traceFossil = Console.ReadLine().ToLower();
        }while(traceFossil != "footprints" && traceFossil != "fossilized nest");
        return traceFossil;
    }
    
    public string PetrifiedFossilDoWhileLoop()
    {
        string petrifiedFossil;
        
        do
        {
            Console.WriteLine("Please, type 'petrified wood', 'dinosaur egg' or 'Petoskey stones'");
            petrifiedFossil = Console.ReadLine().ToLower();
        }while(petrifiedFossil != "footprints" && petrifiedFossil != "fossilized nest");
        return petrifiedFossil;
    }
}