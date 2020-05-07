using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace BLL.Models
{
    public class LoginManager
    {
        private SK4RTContext context;
        public LoginManager()
        {
            context = new SK4RTContext();
        }

        public bool LoginProcessWorker(string _username, string _password)
        {
            List<Workers> workers = context.Workers.ToList()
                .FindAll(x => (x.WorkerUsername == _username && x.WorkerPassword == _password));

            if (workers.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool LoginProcessAdmins(string username, string password)
        {
            List<Admins> admins = context.Admins.ToList().FindAll(x => x.AdminUserName.Trim() == username && x.AdminPassword.Trim() == password);

            if (admins.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetWorkerName(string username, string password)
        {
            return context.Workers.ToList()
                       .FindAll(x => x.WorkerUsername == username && x.WorkerPassword == password)[0].WorkerName + " " +
                   context.Workers.ToList().FindAll(x => x.WorkerUsername == username && x.WorkerPassword == password)
                       [0].WorkerLastName;
        }
    }
}
