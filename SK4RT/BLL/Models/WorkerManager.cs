using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Models;

namespace BLL.Models
{
    public class WorkerManager
    {
        private SK4RTContext context;
        public WorkerManager()
        {
            context = new SK4RTContext();
        }
        public void AddWorker(string workerName, string workerLastname, string workerEmail, string workerUsername, string workerPassword, decimal workerSalary)
        {
            if (!string.IsNullOrEmpty(workerName) &&
               !string.IsNullOrEmpty(workerLastname) &&
                !string.IsNullOrEmpty(workerEmail)&&
                !string.IsNullOrEmpty(workerUsername) &&
                !string.IsNullOrEmpty(workerPassword) &&
                !string.IsNullOrEmpty(workerSalary.ToString()))
            {
                Workers worker = new Workers
                {
                    WorkerName = workerName,
                    WorkerLastName = workerLastname,
                    WorkerEmail = workerEmail,
                    WorkerUsername = workerUsername,
                    WorkerPassword = workerPassword,
                    WorkerSalary = workerSalary
                };

                context.Workers.Add(worker);
                context.SaveChanges();
            }
            else
            {
                //operations..   
            }
        }

        public void UpdateWorker(string updatingWorker,string workerName, string workerLastname, string workerEmail, string workerUsername, string workerPassword, decimal workerSalary)
        {

            if (!string.IsNullOrEmpty(workerName) &&
               !string.IsNullOrEmpty(workerLastname) &&
                !string.IsNullOrEmpty(workerEmail)&&
                !string.IsNullOrEmpty(workerUsername) &&
                !string.IsNullOrEmpty(workerPassword) &&
                !string.IsNullOrEmpty(workerSalary.ToString()))
            {
                List<Workers> workers = context.Workers.ToList()
                    .FindAll(x => (x.WorkerName + " " + x.WorkerLastName) == updatingWorker);
                workers[0].WorkerName = workerName;
                workers[0].WorkerLastName = workerLastname;
                workers[0].WorkerEmail = workerEmail;
                workers[0].WorkerUsername = workerUsername;
                workers[0].WorkerPassword = workerPassword;
                workers[0].WorkerSalary = workerSalary;

                context.Workers.Update(workers[0]);
                context.SaveChanges();
            }
            else
            {
                //opertions..
            }
        }

        public void DeleteWorker(string deletingWorker)
        {
            List<Workers> workers = context.Workers.ToList()
                .FindAll(x => (x.WorkerName + " " + x.WorkerLastName) == deletingWorker);

            context.Workers.Remove(workers[0]);
            context.SaveChanges();
        }

        public List<Workers> FillWorkers(string comboBoxText)
        {
            return context.Workers.ToList().FindAll(x => (x.WorkerName + " " + x.WorkerLastName) == comboBoxText);
        }


        public List<string> BLLGetWorkers()
        {
            return context.Workers.Select(x=> x.WorkerName + " " + x.WorkerLastName).ToList();
        }

        public List<Workers> DataGridViewWorkers()
        {
            return context.Workers.ToList();
        }
    }
}
