using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Q2_Fall22.Models;

namespace Q2_Fall22.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Director_Movies(int id)
        {
            using (var context = new PE_PRN_Fall22B1Context())
            {
                List<Movie> movies;
                if (id != 0) 
                movies = context.Movies.Include(x => x.Producer).Include(x => x.Director).Include(x => x.Genres).Where(x => x.DirectorId == id).ToList();
                else movies = context.Movies.Include(x => x.Producer).Include(x => x.Director).Include(x => x.Genres).ToList();
                ViewBag.directors = context.Directors.ToList();
                ViewData["id"] = id;
                return View(movies);
            }
        }

        public IActionResult Remove(int id, int mid, int gid)
        {
            using (var context = new PE_PRN_Fall22B1Context())
            {
                Movie m = context.Movies.Where(x => x.Id == mid).Include(x => x.Genres).FirstOrDefault();
                m.Genres.Remove(m.Genres.Where(x => x.Id == gid).FirstOrDefault());
                context.SaveChanges();
                return RedirectToAction("Director_Movies", new { id = id });
            }
        }
    }
}
