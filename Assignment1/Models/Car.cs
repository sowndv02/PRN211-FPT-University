using System;
using System.Collections.Generic;

namespace Assignment1.Models
{
    public partial class Car
    {
        
        public Car()
        {
            Orders = new HashSet<Order>();
        }

        public Car(int carId, string? make, string? color, string? petName)
        {
            CarId = carId;
            Make = make;
            Color = color;
            PetName = petName;
        }

        public Car(string? make, string? color, string? petName)
        {
            Make = make;
            Color = color;
            PetName = petName;
        }

        public int CarId { get; set; }
        public string? Make { get; set; }
        public string? Color { get; set; }
        public string? PetName { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }

    public class Admin
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Admin(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
