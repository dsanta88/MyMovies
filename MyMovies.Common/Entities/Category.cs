﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyMovies.Common.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Name { get; set; }
    }
}


