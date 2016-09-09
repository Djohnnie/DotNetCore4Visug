using System;
using System.Collections.Generic;

namespace HelloDatabase.Model {

  public class Category {

    public Guid Id { get; set; }
    public String Name { get; set; }

    public virtual List<Movie> Movies { get; set; }

  }

}