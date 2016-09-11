using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using fitsys.Models;

namespace fitsys.Controllers
{
    public class EnglishController : Controller
    {
        
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult voca()
        {
            
            
            return View();
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
