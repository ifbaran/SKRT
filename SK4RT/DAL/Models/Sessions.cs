using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Sessions
    {
        public Sessions()
        {
            Tickets = new HashSet<Tickets>();
        }

        public int SessionId { get; set; }
        public string SessionName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public virtual ICollection<Tickets> Tickets { get; set; }
    }
}
