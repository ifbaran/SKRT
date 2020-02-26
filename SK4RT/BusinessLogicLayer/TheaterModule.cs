using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BusinessLogicLayer
{
    public class TheaterModule
    {
        DataAccessLayer.DAL dal;
        public DataTable GetTheater()
        {
            dal = new DataAccessLayer.DAL();
            string query = "select * from Theater";
            DataTable Theater = dal.ShowDataInGridView(query);
            return Theater;
        }

        public string TheaterName (int i)
        {
            DataTable Theater =  GetTheater();
            return Theater.Rows[i]["theaterName"].ToString();
        }
    }
}
