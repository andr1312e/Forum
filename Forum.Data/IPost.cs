using Forum.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Forum.Data
{
    public interface IPost
    {
        IPost GetById(int id);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetFilteredPost(string seacrh);
        Task Add(Post post);
        Task Delete(int id);
        Task Edit(int id, string NewContent);
        Task AddReply(PostReply reply);
    }
}
