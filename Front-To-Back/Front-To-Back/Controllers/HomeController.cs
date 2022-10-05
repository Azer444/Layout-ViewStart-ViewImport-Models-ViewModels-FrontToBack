using Front_To_Back.Models;
using Microsoft.AspNetCore.Mvc;


namespace Front_To_Back.Controllers
{
    public class HomeController : Controller
    {
        Car car = new Car
        {
            Id = 150,
            Brand = "Mercedes"
        };

        public IActionResult Index()
        {
            return View(car);
        }

    }
}
