//    using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Text;
//    using Entities;

//    namespace BusinessLogicLayer
//{
//    public class CustomerModule : BaseClass<Customer>
//    {
//        DataAccessLayer.DAL dal;

//        public CustomerModule()
//        {
//            dal = new DataAccessLayer.DAL();
//        }

//        public int Insert(Customer customer)
//        {
//            cmd = new SqlCommand("INSERT INTO Customer VALUES (@CustomerName,@CustomerSurname,@CustomerEmail,@CustomerChosenFilm,@CustomerSeat)");
//            cmd.Parameters.Add("@CustomerName", SqlDbType.NVarChar).Value = customer.CustomerName;
//            cmd.Parameters.Add("@CustomerSurname", SqlDbType.NVarChar).Value = customer.CustomerLastName;
//            cmd.Parameters.Add("@CustomerEMail", SqlDbType.NVarChar).Value = customer.CustomerEmail;
//            result = dal.AddDeleteEdit(cmd);
//            return result;
//        }
//        public int InquiryID(int id) 
//        {
//            cmd = new SqlCommand("select CustomerID from Customer where CustomerID = @id");
//            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
//            obj = dal.GetColumn(cmd);
//            return obj == null ? 0 : (int)obj;
//        }

//        public int Delete (int id)
//        {
//            cmd = new SqlCommand("Delete from Customer where CustomerID = @id ");
//            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
//            result = dal.AddDeleteEdit(cmd);
//            return result;
//        }
//        public int Update (Customer customer)
//        {
//            cmd = new SqlCommand("Update Customer Set (@CustomerName,@CustomerSurname,@CustomerEmail,@CustomerChosenFilm,@CustomerSeat)");
//            cmd.Parameters.Add("@CustomerName", SqlDbType.NVarChar).Value = customer.Name;
//            cmd.Parameters.Add("@CustomerSurname", SqlDbType.NVarChar).Value = customer.Surname;
//            cmd.Parameters.Add("@CustomerEMail", SqlDbType.NVarChar).Value = customer.Email;
//            cmd.Parameters.Add("@CustomerChosenFilm", SqlDbType.NVarChar).Value = customer.CustomerChosenFilm;
//            cmd.Parameters.Add("@CustomerSeat", SqlDbType.NVarChar).Value = customer.CustomerSeat;
//            result = dal.AddDeleteEdit(cmd);
//            return result;
//        }
//        public DataTable GetCustomer()
//        {
//            string query = "Select * from Customer";
//            DataTable dataTable = dal.ShowDataInGridView(query);
//            return dataTable;
//        }

//    }
//}
