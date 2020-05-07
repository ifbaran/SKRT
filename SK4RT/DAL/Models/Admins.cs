using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Admins
    {
        public int AdminId { get; set; }
        public string AdminUserName { get; set; }
        public string AdminPassword { get; set; }
    }
}
