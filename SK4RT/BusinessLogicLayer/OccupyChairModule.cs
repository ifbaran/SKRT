using System;
using System.Collections.Generic;
using System.Data;
using System.Text;


namespace BusinessLogicLayer
{
    public class OccupyChairModule
    {
       // Helper help = new Helper();
       // DataAccessLayer.DAL dal; 

       // public OccupyChairModule()
       // {
       //     dal = new DataAccessLayer.DAL();
       // }

       // public DataTable GetOccupyChair()
       // {
       //     string query = "select * from OccupyChair";
       //     DataTable chair = dal.ShowDataInGridView(query);
       //     return chair;
       // }

       // public bool OccupiedChairStatus()
       // {
       //     string query = @"SELECT 
       //                     F.FilmID,
							//OC.SessionID,
       //                     C.ChairID,
       //                     StartDate,
       //                     EndDate,
       //                     Status
                            
       //                     FROM Sale OC
       //                     inner join Session S on S.SessionID = OC.SessionID
       //                     inner join Film F on F.FilmID = S.FilmID
       //                     inner join Chair as C on C.ChairID = OC.ChairID";
       //     DataTable occupiedChair = dal.ShowDataInGridView(query);
       //     object chair = occupiedChair.Rows[0]["Status"];
       //     bool chairStatus = (bool)chair;

       //     if (chairStatus == true)
       //         return true;
       //     else
       //         return false;
       // }


       // public bool OccupiedChair()
       // {
       //     DataTable occupiedChair = GetOccupyChair();
       //     object chair = occupiedChair.Rows[0]["Status"];
       //     bool chairStatus = (bool)chair;

       //     if (chairStatus == true)
       //     {
       //         return true;
       //     }
       //     else
       //     {
       //         return false;
       //     }
       // }
    }
}
