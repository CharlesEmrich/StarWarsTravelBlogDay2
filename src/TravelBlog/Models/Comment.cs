using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace TravelBlog.Models
{  
    [Table("Comments")]
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public virtual ApplicationUser User { get; set; }
        public string Content { get; set; }
        public int LocationId { get; set; }
    }
}
