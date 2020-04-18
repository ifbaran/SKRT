using System;
using System.Collections.Generic;

namespace DAL.Model
{
    public partial class Chairs
    {
        public int ChairId { get; set; }
        public string ChairName { get; set; }
        public bool? ChairStatus { get; set; }
    }
}
