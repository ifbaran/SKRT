using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Entities
{
    public class Room
    {

        int roomID;
        string name;
        int capacity;

        public int RoomID { get => roomID; set => roomID = value; }
        public string Name { get => name; set => name = value; }
        public int Capacity { get => capacity; set => capacity = value; }
    }
}
