using ForumApp.Data;
using ForumApp.Data.Entities;
using ForumApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ForumApp.Controllers
{
    public class PostsController : Controller
    {
        private readonly ForumAppDbContext data;

        public PostsController(ForumAppDbContext data)
        {
            this.data = data;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> All()
        {
            var posts = await this.data
                .Posts
                .Select(x => new PostViewModel()
                {
                    Id = x.Id,
                    Title = x.Title,
                    Content = x.Content,
                })
                .ToListAsync();

            return View(posts);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(PostFormModel model)
        {
            var post = new Post()
            {
                Title = model.Title,
                Content = model.Content,
            };

            this.data.Posts.Add(post);  
           await this.data.SaveChangesAsync();

           return RedirectToAction("All");
        }

        public IActionResult Edit(int id)
        {
            var post = this.data.Posts.Find(id);
            
            return View(new PostFormModel()
            {
                Title = post.Title,
                Content = post.Content,
            });
        }

        [HttpPost]
        public IActionResult Edit(int id, PostFormModel model)
        {
            var post = this.data.Posts.Find(id);
            post.Title = model.Title;
            post.Content = model.Content;

            this.data.SaveChanges();

            return RedirectToAction("All");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var post = this.data.Posts.Find(id);
            this.data.Posts.Remove(post);

            this.data.SaveChanges();

            return RedirectToAction("All");
        }
    }
}
