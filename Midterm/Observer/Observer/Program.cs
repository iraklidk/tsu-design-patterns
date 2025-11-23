class Program
{
    static void Main()
    {
        var shop = new Shop();

        var user1 = new Customer("Giorgi");
        var user2 = new Customer("Nika");
        var user3 = new Customer("Ana");

        shop.AddCustomer(user1);
        shop.AddCustomer(user2);
        shop.AddCustomer(user3);

        // New products arrive
        shop.AddProduct(new Product("PS5 Console"));
        shop.AddProduct(new Product("Headphones"));
        shop.AddProduct(new Product("iPhone 16 Pro"));

        // Show remaining products
        Console.WriteLine("\nProducts still available:");
        foreach (var p in shop.Products)
            Console.WriteLine($"- {p.Name}");
    }
}