using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_LInQ
{
    static class ListExtensions
    {
        //Khai báo thêm 1 số hàm mà mình tự định nghĩa
        public static void Display(this List<Course> list) // Truyền vào chính tham số đc gọi(Sd để . gọi hàm)
        {
            Console.WriteLine("List of course:");
            foreach (Course c in list)
            {
                Console.WriteLine(c);
            }
        }
    }
}
