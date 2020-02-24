using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace DataAccessLayer
{
    public class DAL
    {
        private string connectionString = @"Data Source = C:\YEREL DİSK D\SK4RT\SK4RT\Database\database.db";
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader reader;
        SQLiteDataAdapter adapter;
        DataSet ds;

        public DAL()
        {
            openConnection();
        }

        private void openConnection()
        {
            con = new SQLiteConnection(connectionString);
            con.Open();
        }

        private void closeConnection()
        {
            con.Close();
        }

        public int ExecuteNonQuery(string query) // Insert,Update,Delete
        {
            cmd = new SQLiteCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            return cmd.ExecuteNonQuery();
        }
        public int ExecuteQueries(string Query_)
        {
            cmd = new SQLiteCommand(Query_, con);
            return cmd.ExecuteNonQuery();

        }
        public SQLiteDataReader dataReader(string query)
        {
            cmd = new SQLiteCommand(query);
            reader = cmd.ExecuteReader();

            closeConnection();
            return reader;
        }

        public DataTable ShowDataInGridView(string query)
        {
            adapter = new SQLiteDataAdapter(query, connectionString);
            ds = new DataSet();
            adapter.Fill(ds);

            DataTable dataTable = ds.Tables[0];
            closeConnection();

            return dataTable;
        }
    }
}
