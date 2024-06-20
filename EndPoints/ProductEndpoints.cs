using ProductManager_Api.Dots;

namespace ProductManager_Api.EndPoints;

public static class ProductEndpoints
{
    public static RouteGroupBuilder MapProductsEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/products");

        List<Products> products = [
            new(1, "Headphones", "Wireless headphones", 100, 10, "Sony", "Electronics", ["https://example.com/headphones.jpg"])
            , new(2, "Keyboard", "Mechanical keyboard", 150, 5, "Logitech", "Electronics", ["https://example.com/keyboard.jpg"])
            , new(3, "Mouse", "Gaming mouse", 80, 15, "Razer", "Electronics", ["https://example.com/mouse.jpg"])
        ];

        group.MapGet("/", () => Results.Ok(products));
        group.MapGet("/{id}", (int id) =>
        {
            Products? product = products.Find(product => product.id == id);

            return product is not null ? Results.Ok(new
            {
                message = "Product found",
                product
            }) : Results.NotFound(
                $"Product with id {id} not found"
            );
        });

        group.MapPost("/", (CreateNewProduct product) =>
        {

            Products products1 = new(
                products.Count + 1,
                product.Name, product.Description, product.Price, product.Quantity, product.Brand, product.Category, product.ImageUrl
            );
            products.Add(products1);

            return Results.Created($"/{products.Count}", products1);
        }).WithParameterValidation();


        group.MapPatch("/{id}", (int id, Products product) =>
        {
            int index = products.FindIndex((product) => product.id == id);
            if (index == -1)
            {

                return Results.NotFound(
                    $"Product with id {id} not found"
                );
            }
            products[index] = new(
               id,
                product.Name, product.Description, product.Price, product.Quantity, product.Brand, product.Category, product.ImageUrl
            );

            return Results.Ok(new
            {
                message = "Updated Successfully",
                id,
                product
            });
        });


        group.MapDelete("/{id}", (int id) =>
        {
            int index = products.FindIndex((product) => product.id == id);
            if (index == -1)
            {

                return Results.NotFound(
                    $"Product with id {id} not found"
                );
            }
            products.RemoveAt(index);

            return Results.Ok(new
            {
                message = "Deleted Successfully",
                id
            });
        });
        return group;




    }


}
