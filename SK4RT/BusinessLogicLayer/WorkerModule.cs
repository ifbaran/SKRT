using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BusinessLogicLayer
{
    public class WorkerModule : Entities.Worker
    {
        DataAccessLayer.DAL dal;
        public bool Insert()
        {
            dal = new DataAccessLayer.DAL();
            try
            {
                string query = string.Format("INSERT INTO Worker ( workerName, workerSurname, workerEmail) VALUES ('{0}','{1}','{2}')", WorkerName, WorkerSurname, WorkerEmail);
                dal.ExecuteNonQuery(query);
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
        public bool Update()
        {
            dal = new DataAccessLayer.DAL();

            try
            {
                string query = string.Format("UPDATE Worker SET workerName = {0}, workerSurname = {1}, workerEmail = {2}", WorkerName, WorkerSurname, WorkerEmail);
                dal.ExecuteNonQuery(query);
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        public DataTable GetWorker()
        {
            dal = new DataAccessLayer.DAL();
            string query = "Select * from Worker";
            var worker = dal.ShowDataInGridView(query);

            return worker;
        }

        public int Delete(int id)
        {
            dal = new DataAccessLayer.DAL();
            string query = string.Format("Delete from Worker where workerID = {0}", id);

            int DeletedWorker = dal.ExecuteQueries(query);
            return DeletedWorker;
        }
    }
}
