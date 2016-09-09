using System.Linq;
using HelloDatabase.DataAccess;
using Microsoft.EntityFrameworkCore;
using static System.Console;

namespace HelloDatabase {

  public class Program {

    public static void Main( string[] args ) {
      WriteLine( " MY MOVIE COLLECTION" );
      WriteLine( "---------------------" );
      WriteLine( );
      using( var db = new MoviesDbContext( ) ) {
        var movieCount = 0;
        if( db.Movies.Any( ) ) {
          foreach( var movie in db.Movies.Include( x => x.Category ) ) {
            movieCount++;
            WriteLine( $"{movieCount:D2}. {movie.Title} ({movie.Category.Name})" );
          }
        } else {
          WriteLine( "No movies in database!" );
        }
      }
      WriteLine( );
      WriteLine( "Press any key to quit..." );
      ReadKey( );
    }

  }

}