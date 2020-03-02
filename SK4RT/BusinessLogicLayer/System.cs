using BusinessLogicLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BusinessLogicLayer
{
    public class System : BaseClass<Worker>
    {
        DataAccessLayer.DAL dal;

        public System()
        {
            dal = new DataAccessLayer.DAL();
        }

        public int Login(string nickname, string password)
        {
            cmd = new SqlCommand("select WorkerID from Worker where Nickname = @nickname and Password = @password");
            cmd.Parameters.Add("@nickname", SqlDbType.NVarChar).Value = nickname;
            cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;
            obj = dal.GetColumn(cmd);
            return obj == null ? 0 : (int)obj;
        }
    }
}
