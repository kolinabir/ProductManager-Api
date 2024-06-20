using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Http.HttpResults;
using ProductManager_Api.Dots;
using ProductManager_Api.EndPoints;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();




app.MapProductsEndpoints();




app.Run();
