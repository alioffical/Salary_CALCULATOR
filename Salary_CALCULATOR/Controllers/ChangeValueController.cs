using Microsoft.AspNetCore.Mvc;

namespace Salary_CALCULATOR.Controllers
{
    public class ChangeValueController : Controller
    {
        [HttpGet]
        public IActionResult ChangeValue()
        {
            return View();
        }
    }
}
