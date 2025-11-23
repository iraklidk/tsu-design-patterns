// ----- Subject / Shop -----
public class Shop
{
    private List<ICustomer> _customers = new List<ICustomer>();
    public List<Product> Products { get; } = new List<Product>();

    public void AddCustomer(ICustomer customer)
    {
        _customers.Add(customer);
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
        Notify(product);
    }

    public void Notify(Product product)
    {
        foreach (var c in _customers)
            c.Update(product, this);
    }

    public void BuyProduct(Product product)
    {
        product.IsSold = true;
        Products.Remove(product);
    }
}