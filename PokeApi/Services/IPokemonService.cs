using PokeApi.DTOs;

namespace PokeApi.Services;

public interface IPokemonService
{
    Task<PokemonDto> GetByIdAsync(string apiId);
}