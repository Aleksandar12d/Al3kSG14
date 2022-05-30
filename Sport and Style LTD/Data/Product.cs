using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sport_and_Style_LTD.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Model { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public string Size { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

        public int ApplicationId { get; set; }
        public Typea  Application { get; set; }

        public int SportId { get; set; }
        public Sport Sport { get; set; }
        
        public double Price { get; set; }
        public string Image { get; set; }
        public DateTime DateRegister { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
