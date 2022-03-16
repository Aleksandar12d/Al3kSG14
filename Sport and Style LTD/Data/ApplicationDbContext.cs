using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Sport_and_Style_LTD.Data;

namespace Sport_and_Style_LTD.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Sport_and_Style_LTD.Data.Category> Category { get; set; }
        public DbSet<Sport_and_Style_LTD.Data.Order> Order { get; set; }
        public DbSet<Sport_and_Style_LTD.Data.Product> Product { get; set; }
        public DbSet<Sport_and_Style_LTD.Data.Sport> Sport { get; set; }
        public DbSet<Sport_and_Style_LTD.Data.Typea> Typea { get; set; }
       
    }
}
