using System;
using System.Collections.Generic;

namespace Forum.Data.Models
{
    public class Post
    {
        public int ID { set; get; }
        public string Title { set; get; }
        public string Content { set; get; }
        public DateTime Created { set; get; }
        public virtual ApplicationUser User { set; get; }
        public virtual Forum forum { set; get; }
        public IEnumerable<PostReply> Replies { set; get; }
    }
}