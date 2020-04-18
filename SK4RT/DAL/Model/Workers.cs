using System;
using System.Collections.Generic;

namespace DAL.Model
{
    public partial class Workers
    {
        public Workers()
        {
            Tickets = new HashSet<Tickets>();
        }

        public int WorkerId { get; set; }
        public string WorkerName { get; set; }
        public string WorkerLastName { get; set; }
        public string WorkerEmail { get; set; }
        public string WorkerUsername { get; set; }
        public string WorkerPassword { get; set; }
        public decimal? WorkerSalary { get; set; }

        public virtual ICollection<Tickets> Tickets { get; set; }
    }
}
