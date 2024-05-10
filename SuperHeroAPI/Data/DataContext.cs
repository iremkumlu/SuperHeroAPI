using Microsoft.EntityFrameworkCore;
using SuperHeroAPI.Controllers;
using SuperHeroAPI.Entities;

namespace SuperHeroAPI.Data
{
    public class DataContext : DbContext
    {
        //veritabanı

        public DataContext()
        {

        }

        public DataContext(DbContextOptions<DataContext> options ) : base (options)
        {

        }

        public DbSet<SuperHero> SuperHeroes { get; set; } 
    }
}
