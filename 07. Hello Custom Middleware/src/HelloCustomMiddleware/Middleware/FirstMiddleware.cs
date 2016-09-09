using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace HelloCustomMiddleware.Middleware {

  public class FirstMiddleware {

    private readonly RequestDelegate _next;

    public FirstMiddleware( RequestDelegate next ) {
      _next = next;
    }

    public async Task Invoke( HttpContext context ) {
      await context.Response.WriteAsync( "First IN - " );
      await _next( context );
      await context.Response.WriteAsync( "First OUT - " );
    }

  }

}