using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Entities
{
    public class Show
    {
        int id;
        string name;
        string author;
        DateTime date;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Author { get => author; set => author = value; }
        public DateTime Date { get => date; set => date = value; }
    }
}
