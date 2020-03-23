using System;

namespace Forum.Data.Models
{
    public class PostReply
    {
        public int Id { set; get; }
        public DateTime Created { set; get; }
        public string Content { set; get; }
        public virtual ApplicationUser User { set; get; }
        public virtual Post Post { set; get; }

    }
}