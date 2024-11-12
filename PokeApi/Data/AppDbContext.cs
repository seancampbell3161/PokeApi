using Microsoft.EntityFrameworkCore;
using PokeApi.Data.Entities;

namespace PokeApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Pokemon> Pokemons { get; set; }
}