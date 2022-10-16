using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class MovieListController : Controller
    {
        // 
        // GET: /MovieList/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /MovieList/Welcome/ 

        public IActionResult Welcome( int ID = 1, string name = "friend", int numTimes = 1)
        {
            ViewData["Id"] = ID;
            ViewData["Message"] = "Hello " + name + ' ' + ID;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

    }
}