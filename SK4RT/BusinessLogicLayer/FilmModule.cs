using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Entities;
using Entities.Concrete;

namespace BusinessLogicLayer
{
    public class FilmModule : BaseClass<Film>
    {
        DataAccessLayer.DAL dal;
        public FilmModule()
        {
            dal = new DataAccessLayer.DAL();
        }

    }
}
