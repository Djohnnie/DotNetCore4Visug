using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VisugMovies.DataAccess;
using VisugMovies.ViewModels;
using VisugMovies.Models;

namespace VisugMovies.Controllers {

  public class GenresController : Controller {

    private readonly IGenreRepository _genreRepository;

    public GenresController( IGenreRepository genreRepository ) {
      _genreRepository = genreRepository;
    }

    public async Task<ActionResult> Index( ) {
      var genres = await _genreRepository.GetAllGenres( );
      return View( new GenreListViewModel { Genres = genres } );
    }

    public ActionResult Add( ) {
      return View( new GenreDetailViewModel( ) );
    }

    [HttpPost]
    public async Task<ActionResult> Add( GenreDetailViewModel vm ) {
      await _genreRepository.AddGenre( new Genre
      {
        Name = vm.Name
      } );
      return RedirectToAction( "Index" );
    }

    public async Task<ActionResult> Edit( Guid id ) {
      var existingGenre = await _genreRepository.GetGenreById( id );
      if( existingGenre != null ) {
        var vm = new GenreDetailViewModel { Name = existingGenre.Name };
        return View( vm );
      } else {
        return RedirectToAction( "Index" );
      }
    }

    [HttpPost]
    public async Task<ActionResult> Edit( Guid id, GenreDetailViewModel vm ) {
      await _genreRepository.EditGenre( new Genre
      {
        Id = id,
        Name = vm.Name
      } );
      return RedirectToAction( "Index" );
    }

    public async Task<ActionResult> Delete( Guid id ) {
      await _genreRepository.DeleteGenreById( id );
      return RedirectToAction( "Index" );
    }

  }

}