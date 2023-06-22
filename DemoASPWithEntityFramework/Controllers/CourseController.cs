using DemoASPWithEntityFramework.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DemoASPWithEntityFramework.Controllers
{
    public class CourseController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            using (var context = new APDatabaseContext())
            {
                ViewBag.Subject = context.Subjects.ToList();
                ViewBag.Instructor = context.Instructors.ToList();
                return View();
            }
        }

        [HttpPost]
        public IActionResult Add(Course course) 
        {
            using (var context = new APDatabaseContext())
            {
                context.Courses.Add(course);
                context.SaveChanges();
                return RedirectToAction("AddStudent", new { courseId = course.CourseId });
            }
        }

        public IActionResult AddStudent(int courseId)
        {
            using (var context = new APDatabaseContext())
            {
                Course course = context.Courses.Find(courseId);
                ViewBag.Course = course;    
                List<Student> students = context.Students.ToList(); 
                return View(students);
            }
        }

        [HttpPost]
        public IActionResult AddStudent(int courseId, string[] selectedStudents)
        {
            using (var context = new APDatabaseContext())
            {
                var course = context.Courses.Where(x => x.CourseId == courseId).FirstOrDefault();

                if (selectedStudents != null && selectedStudents.Length > 0)
                {
                    var students = context.Students.Where(s => selectedStudents.Contains(s.StudentId.ToString())).ToList();

                    foreach (var student in students)
                    {
                        course.Students.Add(student);
                    }
                    context.SaveChanges();
                }
                return Redirect("/Course/List");

            }
        }

        public IActionResult List(int id)
        {
            using(var context = new APDatabaseContext())
            {
                ViewBag.Subjects = context.Subjects.ToList();
                List<Course> courses = context.Courses.Where(x => x.SubjectId ==id).ToList();  
                return View(courses);
            }
        }

        public IActionResult Detail(int id)
        {
            using(var context = new APDatabaseContext())
            {
                
                Course c = context.Courses.Where(x => x.CourseId ==id).FirstOrDefault();
                ViewData["subjectName"] = context.Subjects.Where(x => x.SubjectId == c.SubjectId).FirstOrDefault().SubjectName;
                ViewBag.instructor = context.Instructors.Where(x => x.InstructorId == c.InstructorId).FirstOrDefault();
                return View(c);
            }
        }

        public IActionResult Edit(int id)
        {
            using(var context = new APDatabaseContext()) 
            {
                ViewBag.Subject = context.Subjects.ToList();
                ViewBag.Instructor = context.Instructors.ToList();
                Course c = context.Courses.Where(x =>x.CourseId ==id).FirstOrDefault();
                return View(c);
            }
        }

        public IActionResult DoEdit(Course course)
        {
            using(var context = new APDatabaseContext())
            {
                Course old = context.Courses.Where(x => x.CourseId ==course.CourseId).FirstOrDefault();

                old.InstructorId = course.InstructorId;
                old.SubjectId = course.SubjectId;
                old.CourseCode = course.CourseCode; 
                old.CourseDescription = course.CourseDescription;   

                context.SaveChanges();
                return Redirect("/Course/List");
            }
            
        }

        public IActionResult DoDelete(int id)
        {
            using (var context = new APDatabaseContext())
            {
                Course course = context.Courses
                    .Include(c => c.Students)
                    .FirstOrDefault(x => x.CourseId == id);

                if (course != null)
                {
                    course.Students.Clear();

                    List<CourseSchedule> courseSchedules = context.CourseSchedules
                        .Where(x => x.CourseId == id)
                        .ToList();

                    foreach (CourseSchedule schedule in courseSchedules)
                    {
                        List<RollCallBook> rollCallBooks = context.RollCallBooks
                            .Where(x => x.TeachingScheduleId == schedule.TeachingScheduleId)
                            .ToList();

                        context.RollCallBooks.RemoveRange(rollCallBooks);
                    }

                    context.CourseSchedules.RemoveRange(courseSchedules);
                    context.Courses.Remove(course);
                    context.SaveChanges();
                }

                return Redirect("/Course/List");
            }
        }


    }
}
