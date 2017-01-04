using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetsrv.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public ICollection<Order> Orders { get; set; }
        public string FullName => $"{FirstName} {LastName}";
    }
}
