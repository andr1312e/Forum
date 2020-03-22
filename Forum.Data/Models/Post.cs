using System;

namespace Forum.Data.Models
{
    public class Post
    {
        public int ID { set; get; }
        public string Title { set; get; }
        public string Content { set; get; }
        public DateTime Created { set; get; }
        public virtual ApplicationUser User { set; get; }
    }
}