    using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BusinessLogicLayer
{
    public class CustomerModule : Customer
    {
        DataAccessLayer.DAL dal;
        public bool Insert(Customer customer)
        {
            try
            {
                dal = new DataAccessLayer.DAL();
                string query = string.Format("INSERT INTO Customer (customerName, customerSurname, customerEmail, customerChosenFilm, customerSeat) VALUES ('{0}','{1}','{2}','{3}','{4}')", customer.CustomerName, customer.CustomerSurname, customer.CustomerEmail, customer.CustomerChosenFilm, customer.CustomerSeat);
                dal.ExecuteNonQuery(query);

            }
            catch (Exception)
            {

                return false;
            }

            return true;
        }

        public bool Update(Customer customer)
        {
            try
            {
                dal = new DataAccessLayer.DAL();
                string query = string.Format("UPDATE Customer Set customerName = '{0}', customerSurname = '{1}', customerEmail = '{2}', customerChosenFilm = '{3}',customerSeat = '{4}'", customer.CustomerName, customer.CustomerSurname, customer.CustomerEmail, customer.CustomerChosenFilm, customer.CustomerSeat);
                dal.ExecuteNonQuery(query);

            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        public DataTable GetCustomer()
        {
            dal = new DataAccessLayer.DAL();
            string query = "SELECT * FROM Customer";

            DataTable customers = dal.ShowDataInGridView(query);
            return customers;
        }

        public int Delete(int id)
        {
            dal = new DataAccessLayer.DAL();
            string query = string.Format("Delete from Customer where customerID = {0}", id);

            int DeletedCustomer = dal.ExecuteQueries(query);
            return DeletedCustomer;
        }
    }
}
