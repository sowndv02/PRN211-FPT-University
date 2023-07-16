using Microsoft.AspNetCore.Mvc;

namespace Q3_SamplePE_BySon_Version2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}
