using Microsoft.AspNetCore.Mvc;
using Q2_P3.Models;

namespace Q2_P3.Controllers
{
    public class InfectedCaseController : Controller
    {
        public IActionResult Add()
        {
            using(var context = new PRN292_Spr2020_B1Context())
            {
                ViewBag.province =  context.InfectedCases
                .Where(ic => ic.Province != null)
                .Select(ic => ic.Province)
                .Distinct()
                .ToList();

                ViewBag.nationality = context.InfectedCases
                .Where(ic => ic.Nationality != null)
                .Select(ic => ic.Nationality)
                .Distinct()
                .ToList();

                ViewBag.related = context.InfectedCases.ToList();

                return View();
            }
            
        }
    }
}
