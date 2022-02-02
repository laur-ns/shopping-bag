using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace shopping_basket.Models
{
    public class Actor
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Picture")]
        [Required(ErrorMessage = "Required")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Required")]
        public string Name { get; set; }
        [Display(Name = "Bio")]
        [Required(ErrorMessage = "Required")]
        public string Bio { get; set; }

        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
