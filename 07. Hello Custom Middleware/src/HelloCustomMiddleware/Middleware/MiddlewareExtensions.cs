using Microsoft.AspNetCore.Builder;

namespace HelloCustomMiddleware.Middleware {

  public static class MiddlewareExtensions {

    public static void UseStopwatchMiddleware( this IApplicationBuilder app ) {
      app.UseMiddleware<StopwatchMiddleware>( );
    }

    public static void UseFirstMiddleware( this IApplicationBuilder app ) {
      app.UseMiddleware<FirstMiddleware>( );
    }

    public static void UseSecondMiddleware( this IApplicationBuilder app ) {
      app.UseMiddleware<SecondMiddleware>( );
    }

  }

}