using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Chairs
    {
        public Chairs()
        {
            Tickets = new HashSet<Tickets>();
        }

        public int ChairId { get; set; }
        public string ChairName { get; set; }

        public virtual ICollection<Tickets> Tickets { get; set; }
    }
}
