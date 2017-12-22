using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using AIOTCA3.Entities;


namespace AIOTCA3.DataContexts
{
    public class CommentsDb : DbContext
    {
        public CommentsDb() 
            : base("DefaultConnection")
        {

        }
        public DbSet<Comment> Comments { get; set; }

    }
}