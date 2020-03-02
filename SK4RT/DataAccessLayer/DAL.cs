using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

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
            string SqlConnectionString = "Server=.;Database = SK4RT; User Id = sa; Password =1;";

            //SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            //builder.DataSource = ".";
            //builder.InitialCatalog = "SK4RT";
            //builder.UserID = "sa";
            //builder.Password = "1";
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
            cmd.Connection = con;
            GetConnectionStatus();
            returnObj = cmd.ExecuteScalar();
            GetConnectionStatus();
            return returnObj;
        }
        public DataTable ShowDataInGridView(string query)
        {
            
            adapter = new SqlDataAdapter(query,con);
            GetConnectionStatus();
            ds = new DataSet();
            adapter.Fill(ds);

            DataTable dataTable = ds.Tables[0];
            GetConnectionStatus();
            return dataTable;
        }


        //public DataTable ShowDataInGridView(string query)
        //{
        //    adapter = new SQLiteDataAdapter(query, connectionString);
        //    ds = new DataSet();
        //    adapter.Fill(ds);

        //    DataTable dataTable = ds.Tables[0];
        //    closeConnection();

        //    return dataTable;
        //}


        //private string connectionString = @"DataSource = C:\YEREL DİSK D\SK4RT\SK4RT\Database\database.db";
        //SQLiteConnection con;
        //SQLiteCommand cmd;
        //SQLiteDataReader reader;
        //SQLiteDataAdapter adapter;
        //DataSet ds;
        //SQLConnection con;

        //public DAL()
        //{
        //    openConnection();
        //}

        //private void openConnection()
        //{
        //    con = new SQLiteConnection(connectionString);
        //    con.Open();
        //}

        //private void closeConnection()
        //{
        //    con.Close();
        //}

        //public int ExecuteNonQuery(string query) // Insert,Update,Delete
        //{
        //    cmd = new SQLiteCommand();
        //    cmd.CommandText = query;
        //    cmd.CommandType = CommandType.Text;
        //    return cmd.ExecuteNonQuery();
        //}
        //public int ExecuteQueries(string Query_)
        //{
        //    cmd = new SQLiteCommand(Query_, con);
        //    return cmd.ExecuteNonQuery();

        //}
        //public SQLiteDataReader dataReader(string query)
        //{
        //    cmd = new SQLiteCommand(query);
        //    reader = cmd.ExecuteReader();

        //    closeConnection();
        //    return reader;
        //}

    }
}
