using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sport_and_Style_LTD.Models
{
    public class OrdersVM
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
       
        public int UserId { get; set; }
       

        public int Quantity { get; set; }

        public DateTime OrderedOn { get; set; }
    }
}
