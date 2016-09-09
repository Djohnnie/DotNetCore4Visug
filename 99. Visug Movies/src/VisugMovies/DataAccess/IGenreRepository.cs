using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VisugMovies.Models;

namespace VisugMovies.DataAccess {

  public interface IGenreRepository {

    Task<List<Genre>> GetAllGenres( );

    Task<Genre> GetGenreById( Guid id );

    Task AddGenre( Genre genre );

    Task EditGenre( Genre genre );

    Task DeleteGenreById( Guid id );

  }

}