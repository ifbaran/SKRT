using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BLL.Abstract;
using BLL.Concrete;
using DAL.Model;
using EFEntities.Concrete;

namespace WinUI
{
    public partial class CustomerForm : Form
    {
        private SK4RTContext context;
        public CustomerForm()
        {
            InitializeComponent();
            context = new SK4RTContext();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            GetCustomers();
            grdCustomer.EnableHeadersVisualStyles = false;
            grdCustomer.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 55);
            grdCustomer.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gainsboro;
            grdCustomer.Columns[0].HeaderText = "Customer ID";
            grdCustomer.Columns[1].HeaderText = "Customer Name";
            grdCustomer.Columns[2].HeaderText = "Customer Surname";
            grdCustomer.Columns[3].HeaderText = "Customer Email";
            grdCustomer.Columns[4].Visible = false;
        }

        private void GetCustomers()
        {
            try
            {
                grdCustomer.DataSource = context.Customers.ToList();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }

        }

        private void grdCustomer_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            grdCustomer.ClearSelection();
        }
    }
}
