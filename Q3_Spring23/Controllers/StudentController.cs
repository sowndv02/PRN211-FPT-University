using Microsoft.AspNetCore.Mvc;
using Q3_Spring23.Models;

namespace Q3_Spring23.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult List()
        {
            using(var context = new Other_Spring23Context())
            {
                List<Student> students;
                List<string> genders = new List<string>() { "Male", "Female" };
                ViewBag.genders = genders;
                students = context.Students.ToList();
                ViewBag.id = string.Empty;
                return View(students);
            }    
        }

        [HttpPost]
        public IActionResult List(string id)
        {
            using (var context = new Other_Spring23Context())
            {
                List<Student> students;
                List<string> genders = new List<string>() { "Male", "Female" };
                ViewBag.genders = genders;
                ViewBag.id = id;    
                if (string.IsNullOrEmpty(id))
                    students = context.Students.ToList();
                else students = context.Students.Where(x => x.Sex.ToLower().Equals(id)).ToList();
                return View(students);
            }
        }
    }
}
