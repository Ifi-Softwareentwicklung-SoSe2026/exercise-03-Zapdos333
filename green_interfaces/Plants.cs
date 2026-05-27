using green_interfaces;

public abstract class Plants
{
    public string Name { get; }
    public int AgeInYears { get; }

    public Plants(string name, int ageInYears)
    {
        Name = name;
        AgeInYears = ageInYears;
    }

    public virtual string GetDescription()
    {
        return $"{GetType().Name}: '{Name}', Alter: {AgeInYears} Jahre";
    }
}

public interface ICookable
{
    string GetCookingSuggestion();
}

public interface IWoodProducer
{
    string GetWoodUsage();
}

public class AppleTree : Plants, IWoodProducer
{

    public AppleTree(string name, int ageInYears) : base(name, ageInYears)
    {}

    public override string GetDescription()
    {
        return $"Apfelbaum '{Name}', Alter: {AgeInYears} Jahre";
    }

    public string GetWoodUsage()
    {
        return "Möbel, Werkzeuggriffe, Brennholz";
    }
}

public class Pumpkin : Plants, ICookable
{
    public Pumpkin(string name, int ageInYears) : base(name, ageInYears)
    {}

    public override string GetDescription()
    {
        return $"Kürbis '{Name}', Alter: {AgeInYears} Jahre";
    }

    public string GetCookingSuggestion()
    {
        return "Suppe, Backgemüse";
    }
}

public class ChestnutTree : Plants, IWoodProducer
{
    public ChestnutTree(string name, int ageInYears) : base(name, ageInYears)
    {}

    public override string GetDescription()
    {
        return $"Kastanienbaum '{Name}', Alter: {AgeInYears} Jahre";
    }

    public string GetWoodUsage()
    {
        return "Zäune, Brennholz";
    }
}
