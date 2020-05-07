using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Theaters
    {
        public Theaters()
        {
            Tickets = new HashSet<Tickets>();
        }

        public int TheaterId { get; set; }
        public string TheaterName { get; set; }
        public string TheaterAuthor { get; set; }
        public int? TheaterPeriod { get; set; }

        public virtual ICollection<Tickets> Tickets { get; set; }
    }
}
