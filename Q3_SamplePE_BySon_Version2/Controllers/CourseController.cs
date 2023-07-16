using Q3_SamplePE_BySon_Version2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Q3_SamplePE_BySon_Version2.Controllers
{
    public class CourseController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            using (var context = new APContext())
            {
                ViewBag.Subject = context.Subjects.ToList();
                ViewBag.Instructor = context.Instructors.ToList();
                return View();
            }
        }

        [HttpPost]
        public IActionResult Add(Course course) 
        {
            using (var context = new APContext())
            {
                context.Courses.Add(course);
                context.SaveChanges();
                return RedirectToAction("AddStudent", new { courseId = course.CourseId });
            }
        }

        public IActionResult AddStudent(int courseId)
        {
            using (var context = new APContext())
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
            using (var context = new APContext())
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
            using(var context = new APContext())
            {
                ViewBag.Subjects = context.Subjects.ToList();
                List<Course> courses = context.Courses.Where(x => x.SubjectId ==id).ToList();  
                return View(courses);
            }
        }

        public IActionResult Detail(int id)
        {
            using(var context = new APContext())
            {
                
                Course c = context.Courses.Where(x => x.CourseId ==id).FirstOrDefault();
                ViewData["subjectName"] = context.Subjects.Where(x => x.SubjectId == c.SubjectId).FirstOrDefault().SubjectName;
                ViewBag.instructor = context.Instructors.Where(x => x.InstructorId == c.InstructorId).FirstOrDefault();
                return View(c);
            }
        }

        public IActionResult Edit(int id)
        {
            using(var context = new APContext()) 
            {
                ViewBag.Subject = context.Subjects.ToList();
                ViewBag.Instructor = context.Instructors.ToList();
                Course c = context.Courses.Include(x => x.Students).Where(x =>x.CourseId ==id).FirstOrDefault();
                ViewBag.students = context.Students.ToList();
                return View(c);
            }
        }

        [HttpPost]
        public IActionResult DoEdit(Course course, int[] studentIds)
        {
            using (var context = new APContext())
            {
                var existingCourse = context.Courses
                    .Include(c => c.Students)
                    .FirstOrDefault(c => c.CourseId == course.CourseId);

                if (existingCourse != null)
                {
                    existingCourse.CourseCode = course.CourseCode;
                    existingCourse.CourseDescription = course.CourseDescription;
                    existingCourse.SubjectId = course.SubjectId;
                    existingCourse.InstructorId = course.InstructorId;

                    existingCourse.Students.Clear();
                    foreach (int studentId in studentIds)
                    {
                        var student = context.Students.FirstOrDefault(s => s.StudentId == studentId);
                        if (student != null)
                        {
                            existingCourse.Students.Add(student);
                        }
                    }
                    context.SaveChanges();
                }
            }

            return RedirectToAction("List", "Course");
        }

        public IActionResult DoDelete(int id)
        {
            using (var context = new APContext())
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
