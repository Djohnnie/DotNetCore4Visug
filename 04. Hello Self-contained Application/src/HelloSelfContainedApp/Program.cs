using System.Diagnostics;
using static System.Console;
using static System.Math;

namespace HelloSelfContainedApp {

  public class Program {

    public static void Main( string[] args ) {

      var from = 1000000;
      var to = 2000000;
      var primesFound = 0;

      var sw = Stopwatch.StartNew( );

      for( var number = from; number < to; number++ ) {
        var isPrime = true;
        for( var divider = 2; divider <= Sqrt( number ); divider++ ) {
          if( number % divider == 0 ) {
            isPrime = false;
            break;
          }
        }
        if( isPrime ) {
          primesFound++;
        }
      }

      sw.Stop( );

      WriteLine( $"{primesFound} prime numbers were found!" );
      WriteLine( $"The search took about {sw.Elapsed.TotalSeconds:F2} seconds." );
      ReadKey( );

    }

  }

}