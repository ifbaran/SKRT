using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Entities
{
    public class Film
    {
        public int FilmID { get; set; }
        public string FilmName { get; set; }
        public string FilmAuthor { get; set; }
        public DateTime FilmDate { get; set; }

    }
}
