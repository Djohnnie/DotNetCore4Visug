using System;
using System.Collections.Generic;
using HelloDependencyInjection.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace HelloDependencyInjection.Controllers {

  [Route( "api/[controller]" )]
  public class ValuesController : Controller {

    [HttpGet]
    public IEnumerable<String> Get( [FromServices] IDataHelper dataHelper ) {
      return dataHelper.GetData( );
    }

    [HttpPost]
    public void Post( [FromBody]String value, [FromServices] IDataHelper dataHelper ) {
      dataHelper.AddData( value );
    }

  }

}