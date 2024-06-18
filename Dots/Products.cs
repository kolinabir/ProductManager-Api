namespace ProductManager_Api.Dots;

public record class Products(int id, string Name, string Description, int Price, int Quantity, string Brand, string Category, string[] ImageUrl);
