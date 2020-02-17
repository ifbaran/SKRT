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

        public int executeNonQuery(string query)
        {
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            return cmd.ExecuteNonQuery();
        }

        public SQLiteDataReader dataReader(string query)
        {
            SQLiteCommand cmd = new SQLiteCommand(query);
            SQLiteDataReader dr = cmd.ExecuteReader();

            closeConnection();
            return dr;
        }

        public DataTable showDataInGridView(string query)
        {
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query, connectionString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            DataTable dataTable = ds.Tables[0];
            closeConnection();

            return dataTable;
        }
    }
}
