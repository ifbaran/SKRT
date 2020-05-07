using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace BLL.Models
{
    public class CustomerManager
    {
        private SK4RTContext context;
        public CustomerManager()
        {
            context = new SK4RTContext();
        }

        public bool AddCustomer(string customerName, string customerLastname, string customerEmail)
        {
            if (!string.IsNullOrEmpty(customerName) && !string.IsNullOrEmpty(customerLastname) && !string.IsNullOrEmpty(customerEmail))
            {
                Customers customers = new Customers
                {
                    CustomerName = customerName,
                    CustomerLastName = customerLastname,
                    CustomerEmail = customerEmail
                };
                context.Customers.Add(customers);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
                //operations..
            }
        }

        public void UpdateCustomer(string updatingCustomer, string customerName, string customerLastname, string customerEmail)
        {

            if (!string.IsNullOrEmpty(customerName) &&
                !string.IsNullOrEmpty(customerLastname) &&
                !string.IsNullOrEmpty(customerEmail))
            {
                List<Customers> customers = context.Customers.ToList()
                    .FindAll(x => (x.CustomerName + " " + x.CustomerLastName) == updatingCustomer);
                customers[0].CustomerName = customerName;
                customers[0].CustomerLastName = customerLastname;
                customers[0].CustomerEmail = customerEmail;

                context.Customers.Update(customers[0]);
                context.SaveChanges();
            }
            else
            {
                //opertions..
            }
        }

        public void DeleteCustomer(string deletingCustomer)
        {
            List<Customers> customers = context.Customers.ToList()
                .FindAll(x => (x.CustomerName + " " + x.CustomerLastName) == deletingCustomer);

            context.Customers.Remove(customers[0]);
            context.SaveChanges();
        }

        public List<Customers> FillCustomers(string comboBoxText)
        {
            return context.Customers.ToList().FindAll(x => (x.CustomerName + " " + x.CustomerLastName) == comboBoxText);
        }

        public List<string> BLLGetCustomers()
        {
            return context.Customers.Select(x => x.CustomerName + " " + x.CustomerLastName).ToList();
        }

        public List<Customers> DataGridViewCustomers()
        {
            return context.Customers.ToList();
        }
    }
}
