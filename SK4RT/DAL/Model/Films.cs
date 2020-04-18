using System;
using System.Collections.Generic;

namespace DAL.Model
{
    public partial class Films
    {
        public Films()
        {
            Tickets = new HashSet<Tickets>();
        }

        public int FilmId { get; set; }
        public string FilmName { get; set; }
        public string FilmAuthor { get; set; }
        public int? FilmPeriod { get; set; }

        public virtual ICollection<Tickets> Tickets { get; set; }
    }
}
