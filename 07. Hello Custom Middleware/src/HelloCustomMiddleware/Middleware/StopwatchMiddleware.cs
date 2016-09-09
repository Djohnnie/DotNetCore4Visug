using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;

namespace HelloCustomMiddleware.Middleware {

  public class StopwatchMiddleware {

    private readonly RequestDelegate _next;

    public StopwatchMiddleware( RequestDelegate next ) {
      _next = next;
    }

    public async Task Invoke( HttpContext context ) {
      var sw = Stopwatch.StartNew( );
      context.Response.OnStarting( ( ) =>
       {
         sw.Stop( );
         context.Response.Headers.Add( "X-Stopwatch", new StringValues( $"{sw.Elapsed.TotalMilliseconds:F4}ms" ) );
         return Task.CompletedTask;
       } );
      await _next( context );
      sw.Stop( );
    }

  }

}