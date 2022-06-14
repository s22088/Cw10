using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Ex10.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //public string Welcome(string name, int id) {
        //    return HtmlEncoder.Default.Encode($"{name} got id {id}");
        //}

        public IActionResult Welcome(string name, int id, int numTimes = 3)
        {
            ViewData["Message"] = $"Hello {name}, id {id}";
            ViewData["times"] = numTimes;

            return View();
        }

    }
}
