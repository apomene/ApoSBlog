using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApoSBlog.Models
{
    public class Posts
    {
        public string title { get; set; }
        public string content { get; set; }
        public List<Tag> tags = new List<Tag>();
    }

    public class Tag
    {
        public string title { get; set; }
        public string description { get; set; }
    }
}
