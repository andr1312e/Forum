using Forum.Data;
using Forum.Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service
{
    public class ForumServices : IForum
    {
        Task IForum.Create(Forum.Data.Models.Forum forum)
        {
            throw new NotImplementedException();
        }

        Task IForum.Delete(int forwumId)
        {
            throw new NotImplementedException();
        }

        IEnumerable<ApplicationUser> IForum.GetAllActiveUsers()
        {
            throw new NotImplementedException();
        }

        Forum.Data.Models.Forum IForum.GetById(int id)
        {
            throw new NotImplementedException();
        }

        Task IForum.UpdateForumDescription(int forumId, string NewDescription)
        {
            throw new NotImplementedException();
        }

        Task IForum.UpdateForumTitle(int forumId, string NewTitle)
        {
            throw new NotImplementedException();
        }
    }
}
