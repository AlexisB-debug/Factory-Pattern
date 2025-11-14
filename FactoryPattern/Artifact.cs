namespace FactoryPattern;

public class Artifact : IFind
{
    private string artifact = ArtifactDoWhileLoop();
    public void Unearth()
    {
        switch (artifact.ToLower())
        {
            case "architectural":
                Console.WriteLine("The treasure is a prescription to shelter the bonds in life.\nWhat remains of the brick & mortar that relationships were wrapped in?");
                Console.WriteLine($"{ArchitecturalDoWhileLoop()} is the story of a space!");
                break;
            case "archive":
                Console.WriteLine("The treasure is a warning.\nWhat is the medium of the siren?");
                Console.WriteLine($"{ArchiveDoWhileLoop} is a bridge built to carry messages across time.");
                break;
            case "art":
                Console.WriteLine($"The treasure is revelation that feeling remaining constant through time and through bloodlines.\nSome past heart crafted the {ArtDoWhileLoop()}.");
                break;
            case "religious":
                Console.WriteLine($"The treasure is hope found in {ReligiousDoWhileLoop()}.");
                break;
            case "tool":
                Console.WriteLine("The treasure is that which was forged from fire.\nWhat technology brings man closest to the gods?");
                Console.WriteLine($"{ToolDoWhileLoop()}!");
                break;
            default: //"personal or miscellaneous":
                Console.WriteLine("The treasure is the sky or the world.");
                Console.WriteLine($"Holding {MiscellaneousDoWhileLoop()}");
        }
    }
    
    
    public static string ArtifactDoWhileLoop()
    {
        string artifact;
        
        do
        {
            Console.WriteLine("Please, type 'architectural', 'archive', 'art', 'miscellaneous', 'religious', or 'tool'");
            artifact = Console.ReadLine().ToLower();
        }while(artifact != "architectural" && artifact != "archive" &&  artifact != "art" && artifact != "miscellaneous" && artifact != "religious" &&  artifact != "tool");
        return artifact;
    }
    public string ArchitecturalDoWhileLoop()
    {
        string architectural;
        
        do
        {
            Console.WriteLine("Please, type 'hearth', 'pillars', or 'tumb'");
            architectural = Console.ReadLine().ToLower();
        }while(architectural != "hearth" && architectural != "pillars" &&  architectural != "tomb");
        return architectural;
    }
    public static string ArchiveDoWhileLoop()
    {
        string archive;

        do
        {
            Console.WriteLine("Please, type 'hieroglyphics', 'petroglyphs', 'pictographs', or 'scrolls'");
            archive = Console.ReadLine().ToLower();
        }while(archive != "hieroglyphics" && archive != "petroglyphs" && archive != "pictographs" && archive != "scrolls");
        return archive;
    }
    
    public string ArtDoWhileLoop()
    {
        string art;
        
        do
        {
            Console.WriteLine("Please, type 'installation' or 'sculpture'");
            art = Console.ReadLine().ToLower();
        }while(art != "installation" && art != "sculpture");
        return art;
    }
    
    public string ReligiousDoWhileLoop()
    {
        string religious;
        
        do
        {
            Console.WriteLine("Please, type the 'Ark of the Covenant', the 'Holy Grail', 'Pandora's box', or the 'Shroud of Turin'");
            religious = Console.ReadLine().ToLower();
        }while(religious != "ark of the covenant" && religious != "holy grail" && religious != "pandora's box" && religious != "shroud of turin");
        return religious;
    }
    
    public string ToolDoWhileLoop()
    {
        string tool;
        
        do
        {
            Console.WriteLine("Please, type 'weapons', 'writing utensils', or 'cutlery'");
            tool = Console.ReadLine().ToLower();
        }while(tool != "weapons" && tool != "writing utensils" && tool != "cutlery");
        return tool;
    }
    
    public string MiscellaneousDoWhileLoop()
    {
        string miscellaneous;
        
        do
        {
            Console.WriteLine("Please, type 'coins', 'jewelry', or 'textiles'");
            miscellaneous = Console.ReadLine().ToLower();
        }while(miscellaneous != "coins" && miscellaneous != "jewelry" && miscellaneous != "textiles");
        return miscellaneous;
    }
}