using PokeApi.Data.Entities;

namespace PokeApi.Data.Repositories;

public interface IPokemonRepository
{
    Task<Pokemon> GetPokemonAsync(string apiId);
}