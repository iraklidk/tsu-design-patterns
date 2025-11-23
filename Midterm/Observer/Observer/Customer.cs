// ----- Concrete Observer -----
public class Customer : ICustomer
{
    public string Name { get; }

    public Customer(string name)
    {
        Name = name;
    }

    public void Update(Product product, Shop shop)
    {
        Console.WriteLine($"{Name} notified: New product -> {product.Name}");

        // Simulate buying if customer wants it
        if (product.Name.Contains("PS5") || product.Name.Contains("iPhone"))
        {
            Console.WriteLine($"{Name} bought {product.Name}!");
            shop.BuyProduct(product);
        }
    }
}