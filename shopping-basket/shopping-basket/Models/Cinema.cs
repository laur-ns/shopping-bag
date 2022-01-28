﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace shopping_basket.Models
{
    public class Cinema
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Cinema Logo")]
        public string Logo { get; set; }
        [Display(Name = "Cinema Description")]
        public string Description { get; set; }
        [Display(Name = "Cinema Name")]
        public string Name { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
