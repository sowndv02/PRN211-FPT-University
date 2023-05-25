using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_1
{
    public class Validation
    {
        public static int getInt(int min, int max, string msg)
        {
            int value;
            while (true)
            {
                try
                {
                    Console.Write(msg);
                    value = Convert.ToInt32(Console.ReadLine());
                    if (value < min || value > max) throw new OverflowException("Out of range!");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please input id is Integer!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Out of range!");
                }
            }
            return value;
        }

        public static double getDouble(double min, double max, string msg)
        {
            double value;
            while (true)
            {
                try
                {
                    Console.Write(msg);
                    value = Convert.ToDouble(Console.ReadLine());
                    if (value < min || value > max) throw new OverflowException("Out of range!");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please input id is Integer!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Out of range!");
                }
            }
            return value;
        }

        public static string  getString(int minLength, int maxLength, string msg)
        {
            string value;
            while (true)
            {
                Console.Write(msg);
                value=Console.ReadLine().Trim();
                if (value.Length <= maxLength || value.Length >= minLength)
                    return value;
                Console.WriteLine("Length of String very short or very long!");
            }
        }

        public static DateTime getDateTime(DateTime minDate, DateTime maxDate, string pattern, string msg) 
        {
            DateTime value;
            while (true)
            {
                try
                {
                    Console.Write(msg);
                    value = DateTime.ParseExact(Console.ReadLine(), pattern, null); // Input chinh xac theo format
                    if (value < minDate || value > maxDate) throw new OverflowException("Out of range!");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please input datetime format is " + pattern + "!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Out of range!");
                }
            }
            return value;
        }

    }


}
