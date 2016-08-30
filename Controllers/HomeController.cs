using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using fitsys.Models;

namespace fitsys.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult About()
        {
            List<Blog> blogModel = new List<Blog>();
            using (var db = new BloggingContext())
            {
                db.Blogs.Add(new Blog { Url = "http://blogs.msdn.com/adonet2" });
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All blogs in database:");
                foreach (var blog in db.Blogs)
                {
                    Console.WriteLine(" - {0}", blog.Url);
                }
                blogModel = db.Blogs.ToList();
            }
            
            return View(blogModel);
        }

        public IActionResult Contact()
        {
            
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
