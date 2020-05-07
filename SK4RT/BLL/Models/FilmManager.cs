using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace BLL.Models
{
    public class FilmManager
    {
        private SK4RTContext context;
        public FilmManager()
        {
            context = new SK4RTContext();
        }

        public void AddFilm(string filmName, string filmAuthor, int filmPeriod)
        {
            if (!string.IsNullOrEmpty(filmName) &&
                !string.IsNullOrEmpty(filmAuthor) &&
                !string.IsNullOrEmpty(filmPeriod.ToString()))
            {
                Films films = new Films
                {
                    FilmName = filmName,
                    FilmAuthor = filmAuthor,
                    FilmPeriod = filmPeriod
                };
                context.Films.Add(films);
                context.SaveChanges();
            }
            else
            {
                //operations..
            }
        }

        public void UpdateFilm(string updatingFilm, string filmName, string filmAuthor, int filmPeriod)
        {
            if (!string.IsNullOrEmpty(filmName) &&
                !string.IsNullOrEmpty(filmAuthor) &&
                !string.IsNullOrEmpty(filmPeriod.ToString()))
            {
                List<Films> films = context.Films.ToList().FindAll(x => x.FilmName == updatingFilm);

                films[0].FilmName = filmName;
                films[0].FilmAuthor = filmAuthor;
                films[0].FilmPeriod = filmPeriod;

                context.Films.Update(films[0]);
                context.SaveChanges();
            }
            else
            {
                //operations..
            }
        }

        public void DeleteFilm(string deletingFilm)
        {
            List<Films> films = context.Films.ToList().FindAll(x => x.FilmName == deletingFilm);

            context.Films.Remove(films[0]);
            context.SaveChanges();
        }

        public List<Films> FillFilms(string comboBoxText)
        {
            return context.Films.ToList().FindAll(x => x.FilmName == comboBoxText);
        }

        public List<string> BLLGetFilms()
        {
            return context.Films.Select(x => x.FilmName).ToList();
        }

        public List<Films> DataGridViewFilms()
        {
            return context.Films.ToList();
        }

        public List<string> GetOneFilm()
        {
            return context.Films.Select(x => x.FilmName).ToList();
        }
    }
}
