using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public class Occupy
    {
        DAL dal;
        public Occupy()
        {
            dal = new DAL();
        }
        public DataTable GetOccupyChairs()
        {
                string query = @"SELECT 
                                F.filmName,
                                R.Name,
                                C.ChairNumber,
                                StartDate,
                                EndDate,
                                Status
                            
                                FROM OccupyChair OC
                                INNER JOIN Room R ON R.RoomID = OC.RoomID
                                inner join Session S on S.SessionID = OC.SessionID
                                inner join Films F on F.FilmID = S.FilmID
                                inner join Chair as C on C.ChairID = OC.ChairID";

            return dal.ShowDataInGridView(query);
        }
    }
}
