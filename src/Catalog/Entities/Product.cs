namespace Catalog.Entities;

public class Product
{
    public ICollection<Author> Authors = null!;
    public Guid Id { get; set; }

    public string? Name { get; set; }
}