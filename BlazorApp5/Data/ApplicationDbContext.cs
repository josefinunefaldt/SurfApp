using Microsoft.EntityFrameworkCore;
using BlazorApp5.Data.Entities;

namespace BlazorApp5.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Favourites> FavouriteSpot { get; set; }
    }
}
