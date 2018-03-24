using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApoSBlog.Models;

namespace ApoSBlog.Controllers
{
    public class PostsController : Controller
    {
        public ActionResult Posts()
        {
            List<Posts> p = new List<Posts>();
            p.Add(new Posts() { title = "Post1", content = "content of Post 1" });
            p.Add(new Posts() { title = "Post2", content = "content of Post 2" });
            p.Add(new Posts() { title = "Post3", content = "content of Post 3" });
            return View(p);
        }

        [Route("/Widgets")]
        public ActionResult Widget()
        {
            List<Posts> p = new List<Posts>();
            p.Add(new Posts() { title = "Post1", content = "content of Post 1" });
            p.Add(new Posts() { title = "Post2", content = "content of Post 2" });
            p.Add(new Posts() { title = "Post3", content = "content of Post 3" });
            return View(p);
        }
    }
}