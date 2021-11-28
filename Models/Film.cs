using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeDisney.Models
{
    public class Film
    {
        public int FilmId { get; set; }
        public byte FilmImage { get; set; }
        public string Title { get; set; }
        public DateTime CreationDate { get; set; }
        public int Raring { get; set; }
        public Genre Genre { get; set; }
        public ICollection<Character> Characters { get; set; }


    }
}
