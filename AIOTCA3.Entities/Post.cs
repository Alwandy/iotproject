﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace AIOTCA3.Entities
{
    public class Post
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        [MinLength(500)]
        public string Body { get; set; }
        [Required]
        public string Author { get; set; } = HttpContext.Current.User.Identity.Name;

        public DateTime Date { get; set; } = DateTime.Now;
    }
}
