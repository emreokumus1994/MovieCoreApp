using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieCoreApp.Models;

namespace MovieCoreApp.Controllers
{
    public class HomeController : Controller
    {
        // Default olan bu Startup.cs'de ekledik bu default url'e gitmesini
        // GET: /Home/
        public IActionResult Index()
        {
            //return "This is my default action...";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // 
        // GET: /Home/BasicWelcome/ 

        public string BasicWelcome()
        {
            return "This is the Welcome action method...";
        }
        // 
        // GET: /Home/Welcomev1/ 
        public string Welcomev1(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name},NumTimes is: {numTimes}");
        }

        // GET: /Home/Welcomev2/Id
        public string Welcomev2(string name, int Id = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name},ID is: {Id}");           
        }

        // GET: /Home/Welcome/  PASİSİNG DATA
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
