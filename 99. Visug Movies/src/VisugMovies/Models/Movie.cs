using System;
using System.Collections.Generic;

namespace VisugMovies.Models {

  public class Movie {

    public Guid Id { get; set; }

    public String Title { get; set; }

    public String Director { get; set; }

    public TimeSpan Length { get; set; }

    public virtual Genre Genre { get; set; }

    public Rating Rating { get; set; }

  }

}