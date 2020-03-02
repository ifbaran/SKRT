using BusinessLogicLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    public class Customer:Person

    {
        string customerChosenFilm;
        string customerSeat;

        public string CustomerChosenFilm { get => customerChosenFilm; set => customerChosenFilm = value; }
        public string CustomerSeat { get => customerSeat; set => customerSeat = value; }
    }
}
