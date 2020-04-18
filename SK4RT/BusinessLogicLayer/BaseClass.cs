using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace BusinessLogicLayer
{
    public class BaseClass<T>
    {
        public SqlCommand cmd;
        public SqlDataReader reader;
        public int result;
        public object obj;
        public List<T> list;
        public T data;
        
    }
}
