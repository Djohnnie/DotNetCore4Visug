﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace HelloStaticFiles {

  public class Startup {

    public void ConfigureServices( IServiceCollection services ) {
    }

    public void Configure( IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory ) {
      app.UseDefaultFiles( );
      app.UseStaticFiles( );
    }

  }

}