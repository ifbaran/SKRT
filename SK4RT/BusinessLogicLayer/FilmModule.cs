using BusinessLogicLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace BusinessLogicLayer
{
    public class FilmModule : BaseClass<Film>
    {
        DataAccessLayer.DAL dal;
        public FilmModule()
        {
            dal = new DataAccessLayer.DAL();
        }

        public int Insert(Film film)
        {
            cmd = new SqlCommand("Insert into Film Values (@FilmName,@FilmAuthor,@FilmReleaseDate)");
            cmd.Parameters.Add("@FilmName", SqlDbType.NVarChar).Value = film.Name;
            cmd.Parameters.Add("@FilmAuthor", SqlDbType.NVarChar).Value = film.Author;
            cmd.Parameters.Add("@FilmReleaseDate", SqlDbType.DateTime).Value = film.Date;
            result = dal.AddDeleteEdit(cmd);
            return result;
        }
        public int Update(Film film)
        {
            cmd = new SqlCommand("Update Film set (@FilmName,@FilmAuthor,@FilmReleaseDate)");
            cmd.Parameters.Add("@FilmName", SqlDbType.NVarChar).Value = film.Name;
            cmd.Parameters.Add("@FilmAuthor", SqlDbType.NVarChar).Value = film.Author;
            cmd.Parameters.Add("@FilmReleaseDate", SqlDbType.DateTime).Value = film.Date;
            result = dal.AddDeleteEdit(cmd);
            return result;
        }
        public int Delete(int id)
        {
            cmd = new SqlCommand("Delete from Film Where FilmID = @id");
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            result = dal.AddDeleteEdit(cmd);
            return result;
        }
        public DataTable GetFilm()
        {
            string query = "Select * from Film";
            DataTable Film = dal.ShowDataInGridView(query);
            return Film;
        }
        public string FilmName(int i)
        {
            DataTable films = GetFilm();
            string filmName = films.Rows[i]["FilmName"].ToString();

            return filmName;
        }
    }
}
