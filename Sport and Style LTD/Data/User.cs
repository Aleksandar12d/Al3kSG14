using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sport_and_Style_LTD.Data
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }     
        public virtual ICollection<Order> Orders { get; set; }
        
    }
}
