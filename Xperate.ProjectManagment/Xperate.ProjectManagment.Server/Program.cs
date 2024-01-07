using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// add services to the container.

builder.Services.AddControllers();
// learn more about configuring swagger/openapi at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Register DB context
var ConnectionString = builder.Configuration.GetConnectionString("ProjectMngConnection");
builder.Services.AddDbContext<YourDbContext>(options => options.UseSqlServer(ConnectionString));




var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// configure the http request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
