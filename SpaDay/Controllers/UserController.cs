using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("/users/add")]
        public IActionResult Add()
        {
            return View("add");
        }

        [Route("/users/add")]
        [HttpPost]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            ViewBag.User = newUser;
            if (string.Equals(newUser.Password, verify))
            {
                return View("index");
            }
            else
            {
                ViewBag.Error = true;
                return View("add");
            }
        }
    }
}
