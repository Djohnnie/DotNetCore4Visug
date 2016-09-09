using System;
using Microsoft.AspNetCore.Mvc;

namespace HelloMvc.Controllers {

  public class HomeController : Controller {

    public IActionResult Index( ) {
      return View( );
    }

    public IActionResult About( ) {
      ViewData["Message"] = "Your application description page.";
      throw new ArgumentException();
      return View( );
    }

    public IActionResult Contact( ) {
      ViewData["Message"] = "Your contact page.";

      return View( );
    }

    public IActionResult Error( ) {
      return View( );
    }

  }

}