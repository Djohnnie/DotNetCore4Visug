using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace HelloWeb {

  public class Program {

    public static void Main( string[] args ) {
      var host = new WebHostBuilder( )
                .UseKestrel( )
                .Configure( app =>
                 {
                   app.Run( async context =>
                   {
                     var queryString = context.Request.QueryString.Value;
                     if( !String.IsNullOrEmpty( queryString ) && queryString.StartsWith( "?name=" ) ) {
                       await context.Response.WriteAsync( $"Hello {queryString.Replace( "?name=", "" )}!" );
                     } else {
                       await context.Response.WriteAsync( "Hello!" );
                     }
                   } );
                 } )
                .UseUrls( "http://*:5000" )
                .Build( );
      host.Run( );
    }

  }

}