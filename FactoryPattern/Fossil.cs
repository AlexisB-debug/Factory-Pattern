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
            case "petrified fossil":
                Console.WriteLine("Is the treasure petrified wood, dinosaur egg, or Petoskey stones?");
                Console.WriteLine($"Petrified Fossils are beautiful! Look at the {PetrifiedFossilDoWhileLoop()}");
                break;
            default: //"trace fossil"
                Console.WriteLine("Is the treasure footprints or a fossilized nest?");
                Console.WriteLine($"{TraceFossilDoWhileLoop()}!");
                break;
        }
    }

    public static string FossilDoWhileLoop()
    {
        string fossil;

        do
        {
            Console.WriteLine("Please, type 'body fossil', 'petrified fossil', or 'trace fossil'");
            fossil = Console.ReadLine().ToLower();
        }while(fossil != "body fossil" && fossil != "petrified fossil" && fossil != "trace fossil");
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
    
    public string PetrifiedFossilDoWhileLoop()
    {
        string petrifiedFossil;
        
        do
        {
            Console.WriteLine("Please, type 'dinosaur egg', 'Petoskey stones', or 'petrified wood'");
            petrifiedFossil = Console.ReadLine().ToLower();
        }while(petrifiedFossil != "dinosaur egg" && petrifiedFossil != "Petoskey stones" && petrifiedFossil != "petrified wood");
        return petrifiedFossil;
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
}