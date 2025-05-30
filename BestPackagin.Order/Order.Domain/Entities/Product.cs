using Order.Domain.Entities.ValueObjects;

namespace Order.Domain.Entities;

public class Product
{
    public Product(string id, Dimension dimension)
    {
        Id = id;
        Dimension = dimension;
    }

    public string Id { get; private set; }
    public Dimension Dimension { get; private set; }
}
