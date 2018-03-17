using System.Collections.Generic;
using WebDevLab5.Data.Entities;

namespace WebDevLab5.Repositories
{
    public interface IPokemonRepository
    {
        Pokemon GetPokemon(int id);

        IEnumerable<Pokemon> GetPokemonsForUser(int userId);

        void SavePokemon(Pokemon Pokemon);

        void UpdatePokemon(Pokemon user);

        void DeletePokemon(int id);
    }
}
