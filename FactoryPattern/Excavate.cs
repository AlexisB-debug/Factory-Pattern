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
            default: // "mineral"
                return new Mineral();
        }
    }
}