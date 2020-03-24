using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Forum.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Forum.Models;
using Forum.Models.Forum;

namespace Forum.Controllers
{
    public class HomeController : Controller
    {
        private readonly IForum _forumService;
        private readonly IPost _postService;
        public HomeController(IForum forumService)
        {
            _forumService = forumService;
        }

        public IActionResult Index()
        {
            IEnumerable<ForumListingModel> forums = _forumService.GetAll().Select(forum=>new ForumListingModel
            {
                Id=forum.Id,
                Description=forum.Description,
                Name = forum.Title
            });
            var model = new ForumIndexModel
            {
                ForumList = forums
            };
                
            return View(model);
        }
        public IActionResult Topic(int id) 
        {
            var forum = _forumService.GetById(id);
            var postListing =
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
