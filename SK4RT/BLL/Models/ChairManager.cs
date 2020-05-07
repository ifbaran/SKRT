using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Models;

namespace BLL.Models
{
    public class ChairManager
    {
        private SK4RTContext context;
        public ChairManager()
        {
            context = new SK4RTContext();

        }
        public List<Chairs> GetChairsDGW()
        {
            return context.Chairs.ToList();
        }

        //public List<int?> GetChairsId()
        //{
        //    int ticketChairId =  Convert.ToInt32(context.Chairs.Select(x => x.ChairId));
        //    int ticketSaloonId = Convert.ToInt32(context.Saloons.Select(x => x.SaloonId));
        //    int ticketSessionId = Convert.ToInt32(context.Sessions.Select(x => x.SessionId));
        //    int ticketFilmId = Convert.ToInt32(context.Films.Select(x => x.FilmId));
        //    int ticketTheaterId = Convert.ToInt32(context.Theaters.Select(x => x.TheaterId));

        //    return context.Tickets.Where(x =>
        //        x.ChairId == ticketChairId && x.SaloonId == ticketSaloonId && x.SessionId == ticketSessionId &&
        //        (x.FilmId == ticketFilmId || x.TheaterId == ticketTheaterId)).Select(x=> x.ChairId).ToList();
        //    //return context.Chairs.Where(x => x.ChairId == ticketChairId).Select(x => x.ChairName).ToList();
        //}

        //public bool ChairStatus(List<int?> Chairs)
        //{
        //    Chairs = GetChairsId();

        //    if (Chairs.Count> 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

    }

}