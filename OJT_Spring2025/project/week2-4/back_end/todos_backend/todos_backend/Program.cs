using System.Transactions;
using Microsoft.EntityFrameworkCore;
using todos_backend.Data;
using todos_backend.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TodosDBContext>(
    option =>
    {
        option.UseSqlServer(builder.Configuration.GetConnectionString("TodosDatabase"));
    }
    );
builder.Services.AddTransient<ITodoService, TodoService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Show UseCors with CorsPolicyBuilder
app.UseCors(
    builder =>
    {
        builder.AllowAnyOrigin();
        builder.AllowAnyMethod();
        builder.AllowAnyMethod();
        
    }
    );
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
