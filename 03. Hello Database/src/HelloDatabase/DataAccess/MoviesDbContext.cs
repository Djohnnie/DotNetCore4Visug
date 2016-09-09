using HelloDatabase.Model;
using Microsoft.EntityFrameworkCore;

namespace HelloDatabase.DataAccess {

  public class MoviesDbContext : DbContext {

    public DbSet<Movie> Movies { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder ) {
      optionsBuilder.UseSqlite( "Filename=./movies.db" );
    }

  }

}