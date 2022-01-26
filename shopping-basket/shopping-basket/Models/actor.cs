using System.ComponentModel.DataAnnotations;

namespace shopping_basket.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        public string Profile_Pic { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
    }
}
