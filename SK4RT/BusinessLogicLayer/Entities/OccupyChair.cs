using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Entities
{
    public class OccupyChair
    {
        int occupyChairID;
        int roomID;
        int sessionID;
        int chairID;
        bool status;

        public int OccupyChairID { get => occupyChairID; set => occupyChairID = value; }
        public int RoomID { get => roomID; set => roomID = value; }
        public int SessionID { get => sessionID; set => sessionID = value; }
        public int ChairID { get => chairID; set => chairID = value; }
        public bool Status { get => status; set => status = value; }
    }
}
