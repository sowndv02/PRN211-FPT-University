using Microsoft.AspNetCore.Mvc;
using Q3_Spring23B5.Models;

namespace Q3_Spring23B5.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult List()
        {
            using(var context = new Lab2Context())
            {
                List<Student> students = context.Students.ToList();
                ViewBag.major = "";
                ViewBag.gender = "";
                ViewBag.orderby = "";
                ViewBag.majors = context.Majors.ToList();
                return View(students);
            }
        }
        [HttpPost]
        public IActionResult List(string major, bool gender, string orderby) 
        {
            using(var context = new Lab2Context())
            {
                ViewBag.majors = context.Majors.ToList();
                List<Student> students = context.Students.ToList();
                if(!string.IsNullOrEmpty(major)) students = students.Where(x => x.Major.Equals(major)).ToList();
                ViewBag.major = major;
                ViewBag.gender = gender;
                ViewBag.orderby = orderby;
                students = students.Where(x => x.Gender == gender).ToList();
                if (!string.IsNullOrEmpty(orderby))
                    if (orderby.Equals("Id"))
                        students = students.OrderBy(x => x.Id).ToList();
                    else if (orderby.Equals("Name"))
                        students = students.OrderBy(x => x.Name).ToList();
                    else if (orderby.Equals("Dob"))
                        students = students.OrderBy(x => x.Dob).ToList();

                return View(students);
            }
        }
    }
}
