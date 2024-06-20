namespace ProductManager_Api.Entities;

public class Product
{
    public int id { get; set; }
    public required string Name { get; set; }

    public int UserID { get; set; }

    public User? User { get; set; }

    public required string Description { get; set; }

    public int Price { get; set; }
    public int Quantity { get; set; }

    public required string Brand { get; set; }
    public required string Category { get; set; }
    public required string[] ImageUrl { get; set; }

}
