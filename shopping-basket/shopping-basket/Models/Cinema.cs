using System;
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
        public string Logo { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
