using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using MovieList.Models;

namespace MovieList.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
