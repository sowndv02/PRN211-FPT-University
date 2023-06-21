using Microsoft.AspNetCore.Mvc;

namespace DemoASPWithEntityFramework.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}
