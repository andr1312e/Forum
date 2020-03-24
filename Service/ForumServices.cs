using Forum.Data;
using Forum.Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Service
{
    public class ForumServices : IForum
    {
        public readonly ApplicationDbContext _context;

        public ForumServices(ApplicationDbContext context)
        {
            _context = context;
        }
        Task IForum.Create(Forum.Data.Models.Forum forum)
        {
            throw new NotImplementedException();
        }

        Task IForum.Delete(int forwumId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Forum.Data.Models.Forum> GetAll()=>_context.Forums.Include(forum=>forum.Posts);
        

        IEnumerable<ApplicationUser> IForum.GetAllActiveUsers()
        {
            throw new NotImplementedException();
        }

        Forum.Data.Models.Forum IForum.GetById(int id) => _context.Forums.Where(forum => forum.Id == id)
            .Include(forum=>forum.Posts)
            .ThenInclude(p=>p.User)
            .Include(forum=>forum.Posts)
            .ThenInclude(p=>p.Replies).
            ThenInclude(r=>r.User).
            FirstOrDefault();

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
