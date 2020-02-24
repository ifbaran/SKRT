using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerChosenFilm { get; set; }
        public string CustomerSeat { get; set; }
    }
}
