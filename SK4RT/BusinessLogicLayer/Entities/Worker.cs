using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Entities
{
    public class Worker:Person
    {
        string nickName;
        string password;

        public string NickName { get => nickName; set => nickName = value; }
        public string Password { get => password; set => password = value; }
    }
}
