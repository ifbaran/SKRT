using BusinessLogicLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace BusinessLogicLayer
{
    public class WorkerModule : BaseClass<Worker>
    {
        DataAccessLayer.DAL dal;

        public WorkerModule()
        {
            dal = new DataAccessLayer.DAL();
        }
        public int Insert(Worker worker)
        {
            cmd = new SqlCommand("insert into Worker values (@WorkerName,@WorkerSurname,@WorkerEmail,@Nickname,@Password)");
            cmd.Parameters.Add("@WorkerName", SqlDbType.NVarChar).Value = worker.Name;
            cmd.Parameters.Add("@WorkerSurname", SqlDbType.NVarChar).Value = worker.Surname;
            cmd.Parameters.Add("@WorkerEmail", SqlDbType.NVarChar).Value = worker.Email;
            cmd.Parameters.Add("@Nickname", SqlDbType.NVarChar).Value = worker.NickName;
            cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = worker.Password;
            result = dal.AddDeleteEdit(cmd);
            return result;
        }
        public int Update(Worker worker)
        {
            cmd = new SqlCommand("update Worker set (@WorkerName,@WorkerSurname,@WorkerEmail,@Nickname,@Password)");
            cmd.Parameters.Add("@WorkerName", SqlDbType.NVarChar).Value = worker.Name;
            cmd.Parameters.Add("@WorkerSurname", SqlDbType.NVarChar).Value = worker.Surname;
            cmd.Parameters.Add("@WorkerEmail", SqlDbType.NVarChar).Value = worker.Email;
            cmd.Parameters.Add("@Nickname", SqlDbType.NVarChar).Value = worker.NickName;
            cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = worker.Password;
            result = dal.AddDeleteEdit(cmd);
            return result;
        }
        public int Delete(int id)
        {
            cmd = new SqlCommand("Delete from Worker where WorkerID= @id");
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            result = dal.AddDeleteEdit(cmd);
            return result;
        }
        public DataTable GetWorker()
        {
            string query = "select * from Worker";
            DataTable Theater = dal.ShowDataInGridView(query);
            return Theater;
        }

        // "i" kaçıncı satır olduğunu belirliyor yani filmin satırını buluyor.
        public string GetWorkerName(int i)
        {
            DataTable Theater = GetWorker();
            return Theater.Rows[i]["WorkerName"].ToString();
        }
        
    }
}
