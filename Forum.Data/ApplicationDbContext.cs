using System;
using System.Collections.Generic;
using System.Text;
using Forum.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Forum.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ApplicationUser> ApplicationUsers { set; get; }
        public DbSet<Models.Forum> Forums { set; get; }
        public DbSet<Post> Posts { set; get; }
        public DbSet<PostReply> PostReplies { set; get; }
    }

}
