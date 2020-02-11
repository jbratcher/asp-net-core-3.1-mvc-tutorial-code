using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name = "Jeremy", int numTimes = 1)
        {
            ViewData["Message"] = $"Hi {name}";
            ViewData["NumTimes"] = numTimes;

            return View();
        }

    }
}