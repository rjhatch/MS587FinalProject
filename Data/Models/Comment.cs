using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MS587FinalProject.Data.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public ApplicationUser Id { get; set; }
        public string Text { get; set; }
    }
}
