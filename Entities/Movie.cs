using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeDisney.Entities
{
    public class Movie
    {
        public int MovieId { get; set; }
        public byte Image { get; set; }
        public string Title { get; set; }
       
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }
        public int Rating { get; set; }
        public Genre Genre { get; set; }
        public ICollection<Character> Characters { get; set; }


    }
}
