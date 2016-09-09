using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VisugMovies.Models;

namespace VisugMovies.DataAccess {

  public interface IMovieContext {

    DbSet<Movie> Movies { get; set; }
    DbSet<Genre> Genres { get; set; }
    Task<Int32> SaveChangesAsync( CancellationToken cancellationToken = default( CancellationToken ) );

  }

}