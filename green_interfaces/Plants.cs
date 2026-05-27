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
