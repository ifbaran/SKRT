using BusinessLogicLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace BusinessLogicLayer
{
    public class SessionModule:BaseClass<Session>
    {
        DataAccessLayer.DAL dal;

        public SessionModule()
        {
            dal = new DataAccessLayer.DAL();
        }

        public int Insert(Session session)
        {
            cmd = new SqlCommand("INSERT into Session Values(@RoomID,@FilmID,@TheaterID,@StartDate,@EndDate)");
            cmd.Parameters.Add("@RoomID",SqlDbType.Int).Value = session.RoomID;
            cmd.Parameters.Add("@FilmID", SqlDbType.Int).Value = session.FilmID;
            cmd.Parameters.Add("@TheaterID", SqlDbType.Int).Value = session.TheaterID;
            cmd.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = session.StartDate;
            cmd.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = session.EndDate;
            result = dal.AddDeleteEdit(cmd);
            return result;
        }
        public int Update(Session session)
        {
            cmd = new SqlCommand("Update Session set (@RoomID,@FilmID,@TheaterID,@StartDate,@EndDate)");
            cmd.Parameters.Add("@RoomID", SqlDbType.Int).Value = session.RoomID;
            cmd.Parameters.Add("@FilmID", SqlDbType.Int).Value = session.FilmID;
            cmd.Parameters.Add("@TheaterID", SqlDbType.Int).Value = session.TheaterID;
            cmd.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = session.StartDate;
            cmd.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = session.EndDate;
            result = dal.AddDeleteEdit(cmd);
            return result;
        }
        public int Delete(int id)
        {
            cmd = new SqlCommand("Delete from Session where SessionID = @id");
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            result = dal.AddDeleteEdit(cmd);
            return result;
        }

        public DataTable GetSession()
        {
            string query = "Select * from Session";
            DataTable sessions = dal.ShowDataInGridView(query);
            return sessions;
        }
    }
}
