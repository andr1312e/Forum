using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Data
{
    public  interface IForum
    {
        Models.Forum GetById(int id);
        Task Create(Models.Forum forum);
        Task Delete(int forumId);
        IEnumerable<Models.Forum> GetAll();
        Task UpdateForumTitle(int forumId, string NewTitle);
        Task UpdateForumDescription(int forumId, string NewDescription);
        IEnumerable<ApplicationUser> GetAllActiveUsers();
    }
}
