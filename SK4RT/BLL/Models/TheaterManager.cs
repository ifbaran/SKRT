using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace BLL.Models
{
    public class TheaterManager
    {
        private SK4RTContext context;

        public TheaterManager()
        {
            context = new SK4RTContext();
        }

        public void AddTheater(string theaterName, string theaterAuthor, int theaterPeriod)
        {
            if (!string.IsNullOrEmpty(theaterName) &&
                !string.IsNullOrEmpty(theaterAuthor) &&
                !string.IsNullOrEmpty(theaterPeriod.ToString()))
            {
                Theaters theaters = new Theaters
                {
                    TheaterName = theaterName,
                    TheaterAuthor = theaterAuthor,
                    TheaterPeriod = theaterPeriod
                };
                context.Theaters.Add(theaters);
                context.SaveChanges();
            }
            else
            {
                //operations..
            }
        }

        public void UpdateTheater(string updatingTheater, string theaterName, string theaterAuthor, int theaterPeriod)
        {
            if (!string.IsNullOrEmpty(theaterName) &&
                !string.IsNullOrEmpty(theaterAuthor) &&
                !string.IsNullOrEmpty(theaterPeriod.ToString()))
            {
                List<Theaters> theaters = context.Theaters.ToList().FindAll(x => x.TheaterName == updatingTheater);

                theaters[0].TheaterName = theaterName;
                theaters[0].TheaterAuthor = theaterAuthor;
                theaters[0].TheaterPeriod = theaterPeriod;

                context.Theaters.Update(theaters[0]);
                context.SaveChanges();
            }
            else
            {
                //operations..
            }
        }

        public void DeleteTheater(string deletingTheater)
        {
            List<Theaters> theaters = context.Theaters.ToList().FindAll(x => x.TheaterName == deletingTheater);

            context.Theaters.Remove(theaters[0]);
            context.SaveChanges();
        }

        public List<Theaters> FillTheaters(string comboBoxText)
        {
            return context.Theaters.ToList().FindAll(x => x.TheaterName == comboBoxText);
        }

        public List<string> BLLGetTheaters()
        {
            return context.Theaters.Select(x => x.TheaterName).ToList();
        }

        public List<Theaters> DataGridViewTheaters()
        {
            return context.Theaters.ToList();
        }
    }
}
