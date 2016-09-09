using System;
using System.Collections.Generic;

namespace VisugMovies.Models {

  public class Genre {

    public Guid Id { get; set; }
    public String Name { get; set; }
    public virtual IList<Movie> Movies { get; set; }

  }

}