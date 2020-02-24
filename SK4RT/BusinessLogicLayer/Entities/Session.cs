using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Entities
{
    public class Session
    {
        public int SessionID { get; set; }
        public string RoomID { get; set; }
        public string FilmID { get; set; }
        public string TheaterID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
