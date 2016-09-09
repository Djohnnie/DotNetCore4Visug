using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace HelloCustomMiddleware.Middleware {

  public class SecondMiddleware {

    private readonly RequestDelegate _next;

    public SecondMiddleware( RequestDelegate next ) {
      _next = next;
    }

    public async Task Invoke( HttpContext context ) {
      await context.Response.WriteAsync( "Second IN - " );
      await _next( context );
      await context.Response.WriteAsync( "Second OUT - " );
    }

  }

}