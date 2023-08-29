using CarWorkshopMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CarWorkshopMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            var persons = new List<Person>() 
            {
                new Person() {FirstName = "Łukasz", LastName = "Łopata"},
                new Person() {FirstName = "Adam", LastName = "Mickiewicz"},
            };

            return View(persons);
        }

        public IActionResult About()
        {
            var post = new Post();
            post.Title = "Katharsis HTTP Library";
            post.Description = "Following post describees how to use mentioned library.";
            post.Tags = new List<string>()
            {
                "HTTP", "Katharsis", "Requests"
            };

            return View(post);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}