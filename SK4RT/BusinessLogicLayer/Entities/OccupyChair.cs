using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Entities
{
    public class OccupyChair
    {
        public int OccupyChairID { get; set; }
        public int RoomID { get; set; }
        public int  SessionID { get; set; }
        public int ChiarID { get; set; }
        public bool Status { get; set; }
    }
}
