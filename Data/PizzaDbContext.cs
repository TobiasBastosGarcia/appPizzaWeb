using Microsoft.EntityFrameworkCore;
using PizzaAppWeb.Models;

namespace PizzaAppWeb.Data;

public class PizzaDbContext : DbContext
{

    public DbSet<Pizza> Pizza { get; set; }
    
    public DbSet<Marca> Marca { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var config = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();

        var stringConn = config.GetConnectionString("StringConn");

        optionsBuilder.UseSqlServer(stringConn);
    }
}
