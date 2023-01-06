using Microsoft.AspNetCore.Mvc;
using StoreMVC.Models;
using System.Diagnostics;

namespace StoreMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }


    }
}