using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeDisney.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string Name { get; set; }
        public byte Image { get; set; }
        public ICollection<Movie> Movies { get; set; }

    }
}
