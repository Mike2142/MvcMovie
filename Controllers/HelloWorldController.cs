using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string name = "friend", int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello world. Welcome, {name}! Your id is {ID}");
        }
    }
}