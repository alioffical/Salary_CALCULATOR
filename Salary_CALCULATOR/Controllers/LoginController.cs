using Microsoft.AspNetCore.Mvc;

namespace Salary_CALCULATOR.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (username == "Fotan" && password == "Fotanistan")
            {
                return RedirectToAction("ChangeValue");
            }
            else
            {
                // Optionally, add logic to display an error message or handle incorrect credentials
                ViewBag.ErrorMessage = "Invalid username or password.";
                return View();
            }
        }
    }
}
