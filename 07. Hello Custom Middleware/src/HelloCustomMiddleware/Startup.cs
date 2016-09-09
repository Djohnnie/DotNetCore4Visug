﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloCustomMiddleware.Middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace HelloCustomMiddleware {

  public class Startup {

    public void ConfigureServices( IServiceCollection services ) {
    }

    public void Configure( IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory ) {
      app.UseStopwatchMiddleware( );
      app.UseFirstMiddleware( );
      app.UseSecondMiddleware( );
      app.Run( async ( context ) =>
      {
        await context.Response.WriteAsync( "Hello World!" );
      } );
    }

  }

}