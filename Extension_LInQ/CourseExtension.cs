using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_LInQ
{
    static class CourseExtension
    {
        public static void Display(this Course course, int count = 1) //nếu kh truyền tham số thì giá trị mặc định là 1
        {
            Console.WriteLine($"Course's info {count} times");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(course);
            }
        }
    }
}
