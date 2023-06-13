using System;
using System.Collections.Generic;

namespace DemoEntityFramework.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int CustId { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
