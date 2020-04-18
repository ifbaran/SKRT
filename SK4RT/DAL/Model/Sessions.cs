using System;
using System.Collections.Generic;

namespace DAL.Model
{
    public partial class Sessions
    {
        public Sessions()
        {
            Tickets = new HashSet<Tickets>();
        }

        public int SessionId { get; set; }
        public int SaloonId { get; set; }
        public int? FilmId { get; set; }
        public int? TheaterId { get; set; }
        public DateTime TranDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public virtual ICollection<Tickets> Tickets { get; set; }
    }
}
