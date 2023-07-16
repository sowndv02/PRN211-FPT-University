using Microsoft.AspNetCore.Mvc;
using Q3_SamplePE_Fall21B5.Models;

namespace Q3_SamplePE_Fall21B5.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult List()
        {

            using (var context = new PE_Fall21B5Context())
            {
                List<Employee> employees = context.Employees.ToList();
                return View(employees);
            }
        }

        public IActionResult Delete(int id) 
        {
            using(var context = new PE_Fall21B5Context()) 
            {
                Employee e = context.Employees.Where(x => x.Id == id).FirstOrDefault();
                context.Employees.Remove(e);
                context.SaveChanges();
                return RedirectToAction("List");
            }
        }
    }

}
