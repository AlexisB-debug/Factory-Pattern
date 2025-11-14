namespace FactoryPattern;

public static class Excavate
{
    public static IFind CreateFind(string treasure)
    {
        switch (treasure.ToLower())
        {
            case "artifact":
                return new Artifact();
            case "fossil":
                return new Fossil();
            case "ore":
                return new Ore();
            default:
                Console.WriteLine(treasure);
        }
    }
}