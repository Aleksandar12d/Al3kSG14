using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sport_and_Style_LTD.Data
{
    public class User : IdentityUser
    {
        //public string UserId { get; set; }
        public string FullName { get; set; }     
        //public Role Role { get; set; }
        public virtual ICollection<Order> Order { get; set; }
        
    }
}
