using static System.Console;
using static System.ConsoleColor;

namespace HelloWorld {

  public class Program {

    public static void Main( string[] args ) {
      var previousColor = ForegroundColor;
      ForegroundColor = White;
      Write( "What is your name? " );
      ForegroundColor = Green;
      var name = ReadLine( );
      ForegroundColor = Red;
      WriteLine( $"Hello {name}" );
      ForegroundColor = previousColor;
    }

  }

}