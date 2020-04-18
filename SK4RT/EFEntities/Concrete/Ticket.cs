using System;
using EFEntities.Abstract;

namespace EFEntities.Concrete
{
    public class Ticket : IEntity
    {
        private DateTime _ticketDate;

        public int TicketId { get; set; }
        public int CustomerId { get; set; }
        public int FilmId { get; set; }
        public int TheaterId { get; set; }
        public int SessionId { get; set; }
        public int SaloonId { get; set; }
        public int WorkerId { get; set; }
        public DateTime TicketDate
        {
            get { return _ticketDate; }

            set { _ticketDate.ToShortDateString(); }
        }

    }
}