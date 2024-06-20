using System.ComponentModel.DataAnnotations;

namespace ProductManager_Api.Dots;

public record class CreateNewProduct(
    [Required][StringLength(20)] string Name,
    [Required][StringLength(150)] string Description,
    [Range(1, 1000)] int Price,
    [Range(1, 1000)] int Quantity,
    [Required][StringLength(20)] string Brand,
    [Required][StringLength(20)] string Category,
    [Required] string[] ImageUrl
);