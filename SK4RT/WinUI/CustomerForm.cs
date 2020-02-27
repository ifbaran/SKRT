using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI
{
    public partial class CustomerForm : Form
    {
        BusinessLogicLayer.CustomerModule customerModule = new BusinessLogicLayer.CustomerModule();
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            GetCustomer();
            grdCustomer.EnableHeadersVisualStyles = false;
            grdCustomer.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30,30,55);
            grdCustomer.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gainsboro;
            grdCustomer.Columns[0].HeaderText = "Customer ID";
            grdCustomer.Columns[1].HeaderText = "Customer Name";
            grdCustomer.Columns[2].HeaderText = "Customer Surname";
            grdCustomer.Columns[3].HeaderText = "Customer Email";
            grdCustomer.Columns[4].HeaderText = "Customer Chosen Film";
            grdCustomer.Columns[5].HeaderText = "Customer Seat";
        }

        private void GetCustomer()
        {
            grdCustomer.DataSource = customerModule.GetCustomer();
        }

        private void grdCustomer_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            grdCustomer.ClearSelection();
        }
    }
}
