// ----- Product -----
public class Product
{
    public string Name { get; }
    public bool IsSold { get; set; } = false;

    public Product(string name)
    {
        Name = name;
    }
}