using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VisugMovies.DataAccess;
using VisugMovies.Models;
using VisugMovies.ViewModels;

namespace VisugMovies.Controllers {
  public class MoviesController : Controller {

    private readonly IMovieRepository _movieRepository;
    private readonly IGenreRepository _genreRepository;

    public MoviesController( IMovieRepository movieRepository, IGenreRepository genreRepository ) {
      _movieRepository = movieRepository;
      _genreRepository = genreRepository;
    }

    public async Task<ActionResult> Index( ) {
      var movies = await _movieRepository.GetAllMovies( );
      return View( new MovieListViewModel { Movies = movies } );
    }

    public async Task<ActionResult> Add( ) {
      var genres = await _genreRepository.GetAllGenres( );
      return View( new MovieDetailViewModel { Genres = genres } );
    }

    [HttpPost]
    public async Task<ActionResult> Add( MovieDetailViewModel vm ) {
      await _movieRepository.AddMovie( new Movie
      {
        Title = vm.Title,
        Director = vm.Director,
        Genre = await _genreRepository.GetGenreById( vm.GenreId )
      } );
      return RedirectToAction( "Index" );
    }

    public async Task<ActionResult> Edit( Guid id ) {
      var existingMovie = await _movieRepository.GetMovieById( id );
      var genres = await _genreRepository.GetAllGenres( );
      if( existingMovie != null ) {
        var vm = new MovieDetailViewModel
        {
          Title = existingMovie.Title,
          Director = existingMovie.Director,
          GenreId = existingMovie.Genre.Id,
          Genres = genres
        };
        return View( vm );
      }
      return RedirectToAction( "Index" );
    }

    [HttpPost]
    public async Task<ActionResult> Edit( Guid id, MovieDetailViewModel vm ) {
      await _movieRepository.EditMovie( new Movie
      {
        Title = vm.Title,
        Director = vm.Director,
        Genre = await _genreRepository.GetGenreById( vm.GenreId )
      } );
      return RedirectToAction( "Index" );
    }

    public async Task<ActionResult> Delete( Guid id ) {
      await _movieRepository.DeleteMovieById( id );
      return RedirectToAction( "Index" );
    }

  }

}