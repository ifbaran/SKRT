using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BusinessLogicLayer
{
    public class FilmModule
    {
        DataAccessLayer.DAL dal;
        public DataTable GetFilm()
        {
            dal = new DataAccessLayer.DAL();
            string query = "Select * from Films";
            DataTable Film =  dal.ShowDataInGridView(query);
            return Film;
        }
        public string FilmName(int i)
        {
            DataTable films = GetFilm();
            string filmName = films.Rows[i]["filmName"].ToString();

            return filmName;
        }
    }
}
