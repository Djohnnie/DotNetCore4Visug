using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VisugMovies.Models;

namespace VisugMovies.DataAccess {

  public interface IMovieRepository {

    Task<List<Movie>> GetAllMovies( );

    Task<Movie> GetMovieById( Guid id );

    Task AddMovie( Movie movie );

    Task EditMovie( Movie movie );

    Task DeleteMovieById( Guid id );

  }

}