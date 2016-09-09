using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VisugMovies.Models;

namespace VisugMovies.DataAccess {

  public class GenreRepository : IGenreRepository {

    private readonly IMovieContext _dbContext;

    public GenreRepository( IMovieContext dbContext ) {
      _dbContext = dbContext;
    }

    public Task<List<Genre>> GetAllGenres( ) {
      return _dbContext.Genres.ToListAsync( );
    }

    public Task<Genre> GetGenreById( Guid id ) {
      return _dbContext.Genres.SingleOrDefaultAsync( x => x.Id == id );
    }

    public Task AddGenre( Genre genre ) {
      _dbContext.Genres.Add( genre );
      return _dbContext.SaveChangesAsync( );
    }

    public async Task EditGenre( Genre genre ) {
      var existingGenre = await _dbContext.Genres.SingleOrDefaultAsync( x => x.Id == genre.Id );
      if( existingGenre != null ) {
        existingGenre.Name = genre.Name;
        await _dbContext.SaveChangesAsync( );
      }
    }

    public async Task DeleteGenreById( Guid id ) {
      var existingGenre = await _dbContext.Genres.SingleOrDefaultAsync( x => x.Id == id );
      if( existingGenre != null ) {
        _dbContext.Genres.Remove( existingGenre );
      }
      await _dbContext.SaveChangesAsync( );
    }

  }

}