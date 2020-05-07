using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Customers
    {
        public Customers()
        {
            Tickets = new HashSet<Tickets>();
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerEmail { get; set; }

        public virtual ICollection<Tickets> Tickets { get; set; }
    }
}
