using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VisugMovies.Models;

namespace VisugMovies.DataAccess {

  public class MovieContext : DbContext, IMovieContext {

    private static readonly String _connectionString =
           "Server=tcp:visug-djohnnie.database.windows.net,1433;Initial Catalog=movies;Persist Security Info=False;User ID=djohnnie;Password=visug1234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

    public DbSet<Movie> Movies { get; set; }
    public DbSet<Genre> Genres { get; set; }

    public MovieContext( ) {
    }

    protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder ) {
      optionsBuilder.UseSqlServer( _connectionString );
    }

  }

}