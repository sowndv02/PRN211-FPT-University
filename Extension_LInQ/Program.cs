using Extension_LInQ;

internal class Program
{
    private static void Main(string[] args)
    {

    }

    public static void DemoUsingListExtension()
    {
        List<Course> courses = new List<Course>
            {
                new Course(1, "PRN", new DateTime(2023,1,1)),
                new Course(2, "PRM", new DateTime(2023,2,7)),
                new Course(3, "PRO", new DateTime(2023,3,8)),
                new Course(4, "PRF", new DateTime(2023,4,9)),
            };
        courses.Display();

    }

    public static void DemoUsingCourseExtension()
    {
        Course course = new Course(1, "PRN", new DateTime(2023, 12, 12));
        course.Display(3);
    }
}