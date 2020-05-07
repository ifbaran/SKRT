using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace BLL.Models
{
    public class TicketManager
    {
        private SK4RTContext context;

        public TicketManager()
        {
            context = new SK4RTContext();
        }

        public bool AddTicket(int customerId, int filmId, int theaterId, int chairId, int sessionId, int saloonId, DateTime ticketDateTime)
        {
            if (theaterId == Convert.ToInt32(null) && filmId != Convert.ToInt32(null))
            {
                Tickets ticket = new Tickets
                {
                    CustomerId = customerId,
                    FilmId = filmId,
                    ChairId = chairId,
                    SessionId = sessionId,
                    SaloonId = saloonId,
                    TicketDate = ticketDateTime
                };
                context.Tickets.Add(ticket);
                context.SaveChanges();
                return true;
            }
            if (theaterId != Convert.ToInt32(null) && filmId == Convert.ToInt32(null))
            {
                Tickets ticket = new Tickets
                {
                    CustomerId = customerId,
                    TheaterId = theaterId,
                    ChairId = chairId,
                    SessionId = sessionId,
                    SaloonId = saloonId,
                    TicketDate = ticketDateTime
                };
                context.Tickets.Add(ticket);
                context.SaveChanges();
                return true;
            }

            return false;
        }

        public bool UpdateTicket(int ticketId, int customerId, int filmId, int theaterId, int chairId, int sessionId, int saloonId, DateTime ticketDate)
        {
            List<Tickets> ticket = context.Tickets.Where(x => x.TicketId == ticketId).ToList();
            if (ticketId != null)
            {
                if (theaterId == Convert.ToInt32(null) && filmId != Convert.ToInt32(null))
                {
                    ticket[0].CustomerId = customerId;
                    ticket[0].FilmId = filmId;
                    ticket[0].ChairId = chairId;
                    ticket[0].TheaterId = null;
                    ticket[0].SessionId = sessionId;
                    ticket[0].SaloonId = saloonId;
                    ticket[0].TicketDate = ticketDate;
                    context.Tickets.Update(ticket[0]);
                    context.SaveChanges();
                    return true;
                }

                if (theaterId != Convert.ToInt32(null) && filmId == Convert.ToInt32(null))
                {
                    ticket[0].CustomerId = customerId;
                    ticket[0].TheaterId = theaterId;
                    ticket[0].FilmId = null;
                    ticket[0].ChairId = chairId;
                    ticket[0].SessionId = sessionId;
                    ticket[0].SaloonId = saloonId;
                    ticket[0].TicketDate = ticketDate;
                    context.Tickets.Update(ticket[0]);
                    context.SaveChanges();
                    return true;
                }
            }
            return false;

        }

        public bool DeleteTicket(int id)
        {
            List<Tickets> ticket = context.Tickets.Where(x => x.TicketId == id).ToList();
            if (id != null)
            {
                context.Tickets.Remove(ticket[0]);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Tickets> DataGridViewTickets()
        {
            return context.Tickets.ToList();
        }
    }
}
