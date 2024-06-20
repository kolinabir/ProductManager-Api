using Microsoft.EntityFrameworkCore;
using ProductManager_Api.Entities;

namespace ProductManager_Api.Data;

public class ProductStoreContext(DbContextOptions<ProductStoreContext> options) : DbContext(options)
{

    public DbSet<User> Users => Set<User>();

    public DbSet<Product> Products => Set<Product>();

}
