using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Entities
{
    public class Chair
    {
        int chairID;
        int chairNumber;
        int roomID;
        public int ChairID { get => chairID; set => chairID = value; }
        public int ChairNumber { get => chairNumber; set => chairNumber = value; }
        public int RoomID { get => roomID; set => roomID = value; }
    }
}
