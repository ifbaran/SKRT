using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BusinessLogicLayer
{
    public class Helper
    {
        DataAccessLayer.DAL dal;

        public Helper()
        {
            dal = new DataAccessLayer.DAL();
        }

        public DataTable GetFilms()
        {
            string query = "select * from Film";
            DataTable film = dal.ShowDataInGridView(query);
            return film;
        }
    }
}
