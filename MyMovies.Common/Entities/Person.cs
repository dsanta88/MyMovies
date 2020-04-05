using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyMovies.Common.Entities
{
  public  class Person
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Photo { get; set; }
        public string Bibliography { get; set; }

        [Required]
        public DateTime? DateBirth { get; set; }

    }
}
