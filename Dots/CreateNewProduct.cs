namespace ProductManager_Api.Dots;

public record class CreateNewProduct(
    string Name, string Description, int Price, int Quantity, string Brand, string Category, string[] ImageUrl
);