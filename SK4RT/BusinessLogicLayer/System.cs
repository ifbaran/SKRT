using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Entities.Concrete;

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
            cmd = new SqlCommand("select WorkerId from Worker where WorkerUsername = @nickname and WorkerPassword = @password");
            cmd.Parameters.Add("@nickname", SqlDbType.NVarChar).Value = nickname;
            cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;
            obj = dal.GetColumn(cmd);
            return obj == null ? 0 : (int)obj;
        }
    }
}
