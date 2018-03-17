using System.Data.Entity;
using WebDevLab5.Data.Entities;

namespace WebDevLab5.Data
{
    public interface IDbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Pokemon> Pokemons { get; set; }
    }
}
