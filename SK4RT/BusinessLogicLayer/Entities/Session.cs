using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Entities
{
    public class Session
    {
        int sessionID;
        int roomID;
        int filmID;
        int theaterID;
        DateTime startDate;
        DateTime endDate;

        public int SessionID { get => sessionID; set => sessionID = value; }
        public int RoomID { get => roomID; set => roomID = value; }
        public int FilmID { get => filmID; set => filmID = value; }
        public int TheaterID { get => theaterID; set => theaterID = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
    }
}
