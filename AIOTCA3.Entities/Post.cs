using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AIOTCA3.Entities
{
    public class Post
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }
        [Required]

        public string Body { get; set; }
        [Required]

        public string Author { get; set; }
        [Required]

        public DateTime Date { get; set; }
    }
}
