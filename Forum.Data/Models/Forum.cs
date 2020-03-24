using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Data.Models
{
    public class Forum
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public string Description { set; get; }
        public DateTime Created { set; get; }
        public string ImageUrl { set; get; }
        public virtual IEnumerable<Post> Posts { set; get; }

    }
}
