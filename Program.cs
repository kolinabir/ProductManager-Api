using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Http.HttpResults;
using ProductManager_Api.Data;
using ProductManager_Api.Dots;
using ProductManager_Api.EndPoints;

var builder = WebApplication.CreateBuilder(args);


var connectionString = builder.Configuration.GetConnectionString("ProductStore");
builder.Services.AddSqlite<ProductStoreContext>(connectionString);

var app = builder.Build();




app.MapProductsEndpoints();




app.Run();
