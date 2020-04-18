using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DataAccessLayer
{
    public class DAL
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        SqlDataAdapter adapter;
        DataSet ds;

        int returnInt;
        object returnObj;

        public DAL()
        {
            con = new SqlConnection(GetConnectionString());
        }

        string GetConnectionString()
        {
            string SqlConnectionString = "Server=.;Database = SK4RT; Integrated Security = true";

            //SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            //builder.DataSource = ".";
            //builder.InitialCatalog = "SK4RT";
            //builder.IntegratedSecurity = true;
            return SqlConnectionString;
        }
        public void GetConnectionStatus()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            else
                con.Close();

        }
        public int AddDeleteEdit(SqlCommand cmd)
        {
            cmd.Connection = con;
            GetConnectionStatus();
            returnInt = cmd.ExecuteNonQuery();
            GetConnectionStatus();
            return returnInt;
        }
        public SqlDataReader List(SqlCommand cmd)
        {
            cmd.Connection = con;
            GetConnectionStatus();
            return cmd.ExecuteReader();
        }
        public object GetColumn(SqlCommand cmd)
        {
            //cmd.Connection = con;
            //GetConnectionStatus();
            //returnObj = cmd.ExecuteScalar();
            //GetConnectionStatus();
            return returnObj;
        }

        public DataTable ShowDataInGridView(string query)
        {

            adapter = new SqlDataAdapter(query, con);
            GetConnectionStatus();
            ds = new DataSet();
            adapter.Fill(ds);

            DataTable dataTable = ds.Tables[0];
            GetConnectionStatus();
            return dataTable;
        }

    }
}
