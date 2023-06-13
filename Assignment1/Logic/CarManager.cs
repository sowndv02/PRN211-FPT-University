using Assignment1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace Assignment1.Logic
{
    internal class CarManager
    {
        public static void AddCar(Car car)
        {
            using(var context = new CarsContext()) 
            {
                context.Cars.Add(car);
                context.SaveChanges();
            }
        }

        public static void RemoveCar(int carId)
        {
            using (var context = new CarsContext())
            {
                Car c = context.Cars.First(c => c.CarId == carId);  
                context.Cars.Remove(c);
                context.SaveChanges();
            }
        }

        public static void EditCar(Car c)
        {
            using (var context = new CarsContext())
            {
                Car car = context.Cars.First(x => x.CarId == c.CarId);
                car.Make = c.Make;
                car.Color = c.Color;
                car.PetName = c.PetName;
                context.SaveChanges();
            }
        }

        public static Color GetColorFromName(string colorName)
        {
            if (!string.IsNullOrEmpty(colorName))
            {
                Color color = Color.FromName(colorName);
                if (color.IsKnownColor)
                {
                    return color;
                }
            }

            return SystemColors.Control;
        }

        public static string UppercaseFirstCharacter(string input)
        {
            input = input.Trim();
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }
            char firstChar = char.ToUpper(input[0]);
            string restOfStr = input.Substring(1);
            return firstChar + restOfStr;
        }

        public static Color GetColorFromHex(string hexColor)
        {
            Color color = ColorTranslator.FromHtml(hexColor);
            return color;
        }

            public static string GetColorNameFromHex(string hexColor)
            {
                Color color = ColorTranslator.FromHtml(hexColor);

                if (color.IsNamedColor)
                {
                    return color.Name;
                }

                foreach (KnownColor knownColor in Enum.GetValues(typeof(KnownColor)))
                {
                    Color predefinedColor = Color.FromKnownColor(knownColor);
                    if (predefinedColor.ToArgb() == color.ToArgb())
                    {
                        return predefinedColor.Name;
                    }
                }

                return SystemColors.Control.Name;
            }




    }
}
