namespace FactoryPattern;

public static class FindFactory
{
    public static IFind GetFind(string treasure)
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