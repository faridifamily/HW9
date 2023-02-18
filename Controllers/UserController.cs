using HW9.DAL;
using Microsoft.AspNetCore.Mvc;

namespace HW9.Controllers
{
    public class UserController : Controller
    {
        public IActionResult List()
        {
            var users = UserRepository.Users();
            return View(users);
        }
    }
}
