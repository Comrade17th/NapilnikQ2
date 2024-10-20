public class Good
{
    public string Name { get; }

    public Good(string name)
    {
        if (name == string.Empty)
            throw new ArgumentException();
        
        Name = name;
    }
}