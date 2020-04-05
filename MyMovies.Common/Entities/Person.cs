using System;
using System.Collections.Generic;
using System.Text;

namespace MyMovies.Common.Entities
{
  public  class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public string Bibliography { get; set; }
        public DateTime DateBirth { get; set; }

    }
}
