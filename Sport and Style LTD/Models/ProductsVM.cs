using Sport_and_Style_LTD.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sport_and_Style_LTD.Models
{
    public class ProductsVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Model { get; set; }

        public int IdCategory { get; set; }
       

        public string Size { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

        public int IdApplication { get; set; }

        public int IdSport { get; set; }
       
        public double Price { get; set; }
        
       
        public string Image { get; set; }
        public DateTime DateRegister { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
