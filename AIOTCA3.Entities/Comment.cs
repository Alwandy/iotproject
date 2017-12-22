using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace AIOTCA3.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        // 
        // The Post id to define where comment belongs to
        public int Pid { get; set; }

        [Required]
        [DefaultValue("Guest")]
        public string Poster { get; set; } = HttpContext.Current.User.Identity.Name;
        [Required]
        [MinLength(5)]
        [DataType(DataType.MultilineText)]
        [MaxLength(200)]
        [StringLength(200)]
        public string CommentText { get; set; }

      
        public DateTime Date { get; set; } = DateTime.Now;

    }
}
