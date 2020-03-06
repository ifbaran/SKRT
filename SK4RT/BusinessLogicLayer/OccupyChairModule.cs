using System;
using System.Collections.Generic;
using System.Data;
using System.Text;


namespace BusinessLogicLayer
{
    public class OccupyChairModule
    {
        Helper help = new Helper();
        DataAccessLayer.DAL dal; 

        public OccupyChairModule()
        {
            dal = new DataAccessLayer.DAL();
        }

        public DataTable GetOccupyChair()
        {
            string query = "select * from OccupyChair";
            DataTable chair = dal.ShowDataInGridView(query);
            return chair;
        }

        public bool OccupiedChairStatus()
        {
            string query = @"SELECT 
                            F.FilmID,
                            R.RoomID,
                            C.ChairID,
                            StartDate,
                            EndDate,
                            Status
                            
                            FROM OccupyChair OC
                            INNER JOIN Room R ON R.RoomID = OC.RoomID
                            inner join Session S on S.SessionID = OC.SessionID
                            inner join Film F on F.FilmID = S.FilmID
                            inner join Chair as C on C.ChairID = OC.ChairID";
            DataTable occupiedChair = dal.ShowDataInGridView(query);
            object chair = occupiedChair.Rows[0]["Status"];
            string chairStatus = chair.ToString();

            if (chairStatus == "True")
                return true;
            else
                return false;


            
        }

        public void OccupyChair()
        {
            
        }


        public bool OccupiedChair()
        {
            DataTable occupiedChair = GetOccupyChair();
            object chair = occupiedChair.Rows[0]["Status"];
            string chairStatus = chair.ToString();

            if (chairStatus == "True")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
