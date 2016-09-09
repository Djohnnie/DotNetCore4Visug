using System;
using System.Collections.Generic;

namespace HelloEntityFramework.Models
{
    public partial class Genres
    {
        public Genres()
        {
            Movies = new HashSet<Movies>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Movies> Movies { get; set; }
    }
}
