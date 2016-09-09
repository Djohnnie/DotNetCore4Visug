using System;

namespace HelloDatabase.Model {

  public class Movie {

    public Guid Id { get; set; }
    public String Title { get; set; }
    public String Director { get; set; }
    public TimeSpan Length { get; set; }
    public Rating Rating { get; set; }
    public virtual Category Category { get; set; }

  }

}