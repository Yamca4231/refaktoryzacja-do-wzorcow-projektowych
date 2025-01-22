using Microsoft.EntityFrameworkCore;
using MojBlogCMS.Repository;
using MojBlogCMS.Data;
using MojBlogCMS.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<BlogDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IRepository<Post>, EfCoreRepository<Post>>();

/*var options = new DbContextOptionsBuilder<BlogDbContext>()
    .UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
    .Options;
builder.Services.AddScoped(typeof(IRepository<>), typeof(EfCoreRepository<>));
*/

var app = builder.Build();

/*using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<BlogDbContext>();
    try
    {
        dbContext.Database.OpenConnection();
        Console.WriteLine("Po³¹czenie do bazy danych jest poprawne.");
        dbContext.Database.CloseConnection();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"B³¹d podczas ³¹czenia z baz¹ danych: {ex.Message}");
    }
}
*/

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

