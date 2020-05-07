using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BLL.Enums;
using BLL.Models;
using DAL.Models;

namespace WinUI
{
    public partial class Login : Form
    {
        private BLL.Models.LoginManager loginManager;
        public Login()
        {
            InitializeComponent();
            loginManager = new LoginManager();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        #region Form Hareket İşlemleri

        int Move;
        int Mouse_X;
        int Mouse_Y;
        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation((MousePosition.X - 61) - Mouse_X, MousePosition.Y - Mouse_Y); // -61 yapmazsak form kayıyor.
            }
        }


        #endregion

        // Giriş İşlemleri
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (loginManager.LoginProcessWorker(txtUsername.Text, txtPassword.Text))
            {
                string name = loginManager.GetWorkerName(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                SK4RT form = new SK4RT(LoginType.Worker, name);
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            if (loginManager.LoginProcessAdmins(txtUsername.Text,txtPassword.Text))
            {
                SK4RT form = new SK4RT(LoginType.Admin, "Administrator");
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
