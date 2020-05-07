using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace BLL.Models
{
    public class SessionManager
    {
        private SK4RTContext context;
        public SessionManager()
        {
            context = new SK4RTContext();
        }

        public bool AddSession(string sessionName,DateTime startTime, DateTime endTime)
        {
            if (startTime != null && endTime != null)
            {
                Sessions session = new Sessions
                {
                    SessionName = sessionName,
                    StartTime = startTime,
                    EndTime = endTime
                };
                context.Sessions.Add(session);
                context.SaveChanges();
                return true;    
            }
            else
            {
                return false;
            }
        }

        public bool UpdateSession(int id, DateTime startTime, DateTime endTime)
        {
            if (startTime != null && endTime != null)
            {
                List<Sessions> session = context.Sessions.Where(x => x.SessionId == id).ToList();
                session[0].StartTime = startTime;
                session[0].EndTime = endTime;
                context.Sessions.Update(session[0]);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteSession(int id)
        {
            if (id != null)
            {
                List<Sessions> session = context.Sessions.Where(x => x.SessionId == id).ToList();
                context.Sessions.Remove(session[0]);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<string> GetSessions()
        {
            return context.Sessions.Select(x => x.SessionName).ToList();
        }

        public List<Sessions> SessionsDGW()
        {
            return context.Sessions.ToList();
        }

    }
}
