using System;
using System.Collections.Generic;

namespace DAL.Model
{
    public partial class Tickets
    {
        public int TicketId { get; set; }
        public int? CustomerId { get; set; }
        public int? FilmId { get; set; }
        public int? TheaterId { get; set; }
        public int? SessionId { get; set; }
        public int? SaloonId { get; set; }
        public int? WorkerId { get; set; }
        public DateTime TicketDate { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual Films Film { get; set; }
        public virtual Saloons Saloon { get; set; }
        public virtual Sessions Session { get; set; }
        public virtual Theaters Theater { get; set; }
        public virtual Workers Worker { get; set; }
    }
}
