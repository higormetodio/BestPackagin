namespace Order.Domain.Entities;

public class Order
{
    public Order(int id, IEnumerable<Product> products)
    {
        Id = id;
        Products = products;
    }

    public int Id { get; private set; }
    public IEnumerable<Product> Products { get; private set; }
}
