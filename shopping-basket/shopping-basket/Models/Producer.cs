using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace shopping_basket.Models
{
    public class Producer
    {
        [Key]
        public int ID { get; set; }
        public string ProfilePictureURL { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
