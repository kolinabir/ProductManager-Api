

```markdown
# ProductManager API

ProductManager API is a simple API built with ASP.NET Core that allows you to manage a list of products. It supports basic CRUD (Create, Read, Update, Delete) operations.

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download/dotnet/)

### Running the Application

1. Clone the repository:

    ```bash
    git clone https://github.com/kolinabir/ProductManager-Api
    cd ProductManager_Api
    ```

2. Build and run the application:

    ```bash
    dotnet run
    ```


## API Endpoints

### Get All Products

- **URL:** `/`
- **Method:** `GET`

### Get a Product by ID

- **URL:** `/{id}`
- **Method:** `GET`

### Create a New Product

- **URL:** `/`
- **Method:** `POST`
- **Request Body:**

    ```json
    {
        "name": "New Product",
        "description": "Product description",
        "price": 200,
        "quantity": 20,
        "brand": "BrandName",
        "category": "CategoryName",
        "imageUrl": ["https://example.com/product.jpg"]
    }
    ```

### Update a Product

- **URL:** `/{id}`
- **Method:** `PATCH`
- **Request Body:**

    ```json
    {
        "id": 1,
        "name": "Updated Product",
        "description": "Updated description",
        "price": 220,
        "quantity": 15,
        "brand": "UpdatedBrand",
        "category": "UpdatedCategory",
        "imageUrl": ["https://example.com/updated_product.jpg"]
    }
    ```

### Delete a Product

- **URL:** `/{id}`
- **Method:** `DELETE`

## Project Structure

- `Program.cs`: The main entry point of the application. Contains the API endpoint definitions.
- `Products.cs`: The model class representing a product.
- `CreateNewProduct.cs`: The model class for creating a new product.

## Models

### Products

```csharp
public class Products
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public string Brand { get; set; }
    public string Category { get; set; }
    public List<string> ImageUrl { get; set; }
}
```

### CreateNewProduct

```csharp
public class CreateNewProduct
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public string Brand { get; set; }
    public string Category { get; set; }
    public List<string> ImageUrl { get; set; }
}
```



