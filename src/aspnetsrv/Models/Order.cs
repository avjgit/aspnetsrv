using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetsrv.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int GoodId { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
        public bool IsPaid { get; set; }
        public DateTime? DeliveryDate { get; set; }


        public Customer Customer { get; set; }
        public Good Good { get; set; }

    }
}
