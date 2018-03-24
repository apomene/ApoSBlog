using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApoSBlog.Models;

namespace ApoSBlog.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult Posts()
        {
            List<Posts> p = new List<Posts>();
            p.Add(new Posts() { title = "Post1", content = "content of Post 1" });
            p.Add(new Posts() { title = "Post2", content = "content of Post 2" });
            p.Add(new Posts() { title = "Post3", content = "content of Post 3" });
            return View(p);
        }
    }
}
