using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AIOTCA3.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AIOTCA3.DataContexts
{
    public class IdentityDb : IdentityDbContext<ApplicationUser>
    {
        public IdentityDb() 
            : base("DefaultConnection")
        {
            
        }

        public System.Data.Entity.DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}