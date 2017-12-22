using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AIOTCA3.Entities;

namespace AIOTCA3.Models
{
    public class PostViewModels
    {
        public Post Post { get; set; }
        public IQueryable<Comment> IComment { get; set; }
        public Comment Comment { get; set; }
    }
}