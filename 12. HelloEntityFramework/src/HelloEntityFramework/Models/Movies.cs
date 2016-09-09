using System;
using System.Collections.Generic;

namespace HelloEntityFramework.Models
{
    public partial class Movies
    {
        public Guid Id { get; set; }
        public string Director { get; set; }
        public Guid? GenreId { get; set; }
        public TimeSpan Length { get; set; }
        public int Rating { get; set; }
        public string Title { get; set; }

        public virtual Genres Genre { get; set; }
    }
}
