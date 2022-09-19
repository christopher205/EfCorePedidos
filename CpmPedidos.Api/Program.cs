using CpmPedidos.Api;
using CpmPedidos.Repository.Common;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.




builder.Services.AddControllers();

builder.Services.AddDbContext<AplicationDbContext>(options =>
options.UseSqlServer(
    
    assembly => assembly.MigrationsAssembly(typeof(AplicationDbContext).Assembly.FullName)
    )
);

DependencyInjection.Register(builder.Services);


var app = builder.Build();


//var conexao =  app.Configuration.GetConnectionString("App");


// Configure the HTTP request pipeline.
app.Configuration.GetConnectionString("App");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

