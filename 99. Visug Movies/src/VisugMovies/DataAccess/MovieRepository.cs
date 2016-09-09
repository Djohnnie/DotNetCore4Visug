using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VisugMovies.Models;

namespace VisugMovies.DataAccess {

  public class MovieRepository : IMovieRepository {

    private readonly IMovieContext _dbContext;

    public MovieRepository( IMovieContext dbContext ) {
      _dbContext = dbContext;
    }

    public Task<List<Movie>> GetAllMovies( ) {
      return _dbContext.Movies.Include( x => x.Genre ).ToListAsync( );
    }

    public Task<Movie> GetMovieById( Guid id ) {
      return _dbContext.Movies.SingleOrDefaultAsync( x => x.Id == id );
    }

    public Task AddMovie( Movie movie ) {
      _dbContext.Movies.Add( movie );
      return _dbContext.SaveChangesAsync( );
    }

    public async Task EditMovie( Movie movie ) {
      var existingMovie = await _dbContext.Movies.SingleOrDefaultAsync( x => x.Id == movie.Id );
      if( existingMovie != null ) {
        existingMovie.Title = movie.Title;
        existingMovie.Director = movie.Director;
        existingMovie.Genre = movie.Genre;
        await _dbContext.SaveChangesAsync( );
      }
    }

    public async Task DeleteMovieById( Guid id ) {
      var existingMovie = await _dbContext.Movies.SingleOrDefaultAsync( x => x.Id == id );
      if( existingMovie != null ) {
        _dbContext.Movies.Remove( existingMovie );
      }
      await _dbContext.SaveChangesAsync( );
    }

  }

}