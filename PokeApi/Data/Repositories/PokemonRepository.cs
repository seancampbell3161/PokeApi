using Microsoft.EntityFrameworkCore;
using PokeApi.Data.Entities;

namespace PokeApi.Data.Repositories;

public class PokemonRepository : IPokemonRepository
{
    private readonly AppDbContext _context;

    public PokemonRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Pokemon> GetPokemonAsync(string apiId)
    {
        try
        {
            var entity = await _context.Pokemons.Where(x => x.ApiId == apiId).FirstOrDefaultAsync();

            if (entity != null)
            {
                return entity;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        
        return new Pokemon();
    }
}