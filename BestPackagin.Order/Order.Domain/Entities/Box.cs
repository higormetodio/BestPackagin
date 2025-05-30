using Order.Domain.Entities.ValueObjects;

namespace Order.Domain.Entities;

public class Box
{
    public Box(int id, string description, Dimension dimension)
    {
        Id = id;
        Description = description;
        Dimension = dimension;
    }

    public int Id { get; private set; }
    public string Description { get; private set; }
    public Dimension Dimension { get; private set; }

    public int CalculateBoxVolume()
    {
        return Dimension.Height * Dimension.Width * Dimension.Length;
    }
}
