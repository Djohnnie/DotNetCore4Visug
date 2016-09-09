using Microsoft.AspNetCore.Builder;

namespace HelloMiddleware {

  public class Startup {

    public void Configure( IApplicationBuilder app )
    {

      //app.Run( async c =>
      //   {
      //     if( c.Request.Path.Value.Contains( "bla" ) ) {
      //       await c.Response.WriteAsync( "Middleware!" );
      //     }
      //   } );
    }

  }

}