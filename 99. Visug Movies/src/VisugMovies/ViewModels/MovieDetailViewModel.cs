using System;
using System.Collections.Generic;
using VisugMovies.Models;

namespace VisugMovies.ViewModels {

  public class MovieDetailViewModel {

    public String Title { get; set; }
    public String Director { get; set; }
    public Guid GenreId { get; set; }
    public List<Genre> Genres { get; set; }

  }

}