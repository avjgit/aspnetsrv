using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetsrv.Models
{
    public class Good
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int AmountInStock { get; set; }
        public int AmountOrdered { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
