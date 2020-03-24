using Forum.Models.Forum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models.Post
{
    public class PostListingModel
    {
        public int id { set; get; }
        public string Title { set; get; }
        public string AuthorName { set; get; }
        public int AuthorRating { set; get; }
        public int AuthorId { set; get; }
        public DateTime DayPosted { set; get; }
        public ForumListingModel Forum { set; get; }
        //public int ForumId { set; get; }
        //public string ForumImageUrl { set; get; }
        //public string ForumName { set; get; }
        public int RepliesCount { set; get; }
    }
}
