using Microsoft.EntityFrameworkCore;
using Repozytorium.Repository;
using Repozytorium.Data;
using Repozytorium.Models;



var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<BlogDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IRepository<Post>, EfCoreRepository<Post>>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
