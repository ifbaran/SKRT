using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Saloons
    {
        public Saloons()
        {
            Tickets = new HashSet<Tickets>();
        }

        public int SaloonId { get; set; }
        public string SaloonName { get; set; }

        public virtual ICollection<Tickets> Tickets { get; set; }
    }
}
