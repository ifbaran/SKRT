using BusinessLogicLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace BusinessLogicLayer
{
    public class TheaterModule : BaseClass<Theater>
    {
        DataAccessLayer.DAL dal;

        public TheaterModule()
        {
            dal = new DataAccessLayer.DAL();
        }

        public int Insert(Theater theater)
        {
            cmd = new SqlCommand("insert into Theater values (@TheaterName,@TheaterAuthor,@TheaterDate)");
            cmd.Parameters.Add("@TheaterName", SqlDbType.NVarChar).Value = theater.Name;
            cmd.Parameters.Add("@TheaterAuthor", SqlDbType.NVarChar).Value = theater.Author;
            cmd.Parameters.Add("@TheaterDate", SqlDbType.DateTime).Value = theater.Date;
            result = dal.AddDeleteEdit(cmd);
            return result;
        }
        public int Update (Theater theater)
        {
            cmd = new SqlCommand("Update Theater Set (@TheaterName,@TheaterAuthor,@TheaterDate)");
            cmd.Parameters.Add("@TheaterName", SqlDbType.NVarChar).Value = theater.Name;
            cmd.Parameters.Add("@TheaterAuthor", SqlDbType.NVarChar).Value = theater.Author;
            cmd.Parameters.Add("@TheaterDate", SqlDbType.DateTime).Value = theater.Date;
            result = dal.AddDeleteEdit(cmd);
            return result;
        }
        public int Delete(int id)
        {
            cmd = new SqlCommand("Delete from Theater where TheaterID = @id");
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            result = dal.AddDeleteEdit(cmd);
            return result;
        }
        public DataTable GetTheater()
        {
            string query = "select * from Theater";
            DataTable Theater = dal.ShowDataInGridView(query);
            return Theater;
        }

        // "i" kaçıncı satır olduğunu belirliyor yani filmin satırını buluyor.
        public string GetTheaterName(int i)
        {
            DataTable Theater = GetTheater();
            return Theater.Rows[i]["TheaterName"].ToString();
        }
    }
}
