using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Entities.Concrete;

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
            cmd = new SqlCommand("INSERT into Sessions Values(@sessionTime)");
            cmd.Parameters.Add("@sessionTime", SqlDbType.DateTime).Value = session.SessionTime;
            result = dal.AddDeleteEdit(cmd);
            return result;
        }
        public int Update(Session session)
        {
            cmd = new SqlCommand("Update Sessions set (@sessionTime)");
            cmd.Parameters.Add("@sessionTime", SqlDbType.DateTime).Value = session.SessionTime;
            result = dal.AddDeleteEdit(cmd);
            return result;
        }
        public int Delete(int id)
        {
            cmd = new SqlCommand("Delete from Sessions where SessionID = @id");
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            result = dal.AddDeleteEdit(cmd);
            return result;
        }

        public DataTable GetSession()
        {
            string query = "Select * from Sessions";
            DataTable sessions = dal.ShowDataInGridView(query);
            return sessions;
        }

        public object GetSessionTime()
        {
            cmd  = new SqlCommand("Select StartDate from Sessions");
            object SessionTime = dal.GetColumn(cmd);
            return SessionTime;
        }
    }
}
