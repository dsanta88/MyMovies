using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyMovies.Common.Entities
{
   public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public string Summary { get; set; }
        public bool InTheater { get; set; }

        [Required]
        public DateTime? DatePremiere { get; set; }
        public string Trailer { get; set; }
        public string TitleShort { get; set; }
        public string Poster { get; set; }
    }
}
