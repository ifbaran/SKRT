using BusinessLogicLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BusinessLogicLayer
{
    public class TheaterModule : Entities.Theater
    {
        DataAccessLayer.DAL dal;

        public bool Insert(Theater theater)
        {
            dal = new DataAccessLayer.DAL();
            try
            {
                string query = string.Format("INSERT INTO Theater (theaterName, theaterAuthor, theaterDate) VALUES ('{0}','{1}','{2}') ", TheaterName, TheaterAuthor, TheaterDate);
                dal.ExecuteNonQuery(query);

            }
            catch (Exception)
            {

                return false;
            }
            return true;

        }

        public bool Update(Theater theater)
        {
            dal = new DataAccessLayer.DAL();

            try
            {
                string query = string.Format("UPDATE Theater SET theaterName = '{0}',theaterAuthor = '{1}',theaterDate = '{2}'", TheaterName, TheaterAuthor, TheaterDate);
                dal.ExecuteNonQuery(query);
            }
            catch (Exception)
            {

                return false;
            }

            return true;
        }

        public int Delete(int id)
        {
            dal = new DataAccessLayer.DAL();

            string query = string.Format("DELETE FROM Theater WHERE theaterID = {0}", id);
            int DeletedTheater = dal.ExecuteQueries(query);
            return DeletedTheater;

        }
        public DataTable GetTheater()
        {
            dal = new DataAccessLayer.DAL();
            string query = "select * from Theater";
            DataTable Theater = dal.ShowDataInGridView(query);
            return Theater;
        }

        // "i" kaçıncı satır olduğunu belirliyor yani filmin satırını buluyor.
        public string GetTheaterName(int i)
        {
            DataTable Theater = GetTheater();
            return Theater.Rows[i]["theaterName"].ToString();
        }
    }
}
