using BusinessLogic;
using Entities;
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
    public partial class LoginForm : Form
    {
        private static LoginForm instance;
        private LoginForm()
        {
            InitializeComponent();
            Icon icon = Icon.ExtractAssociatedIcon("D:/Source Visual Studio/MyDigitalShop/favicon.ico");
            this.Icon = icon;
        }

        public static LoginForm Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoginForm();
                }
                return instance;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("Utilizatorul nu este completat", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Parola nu este completat", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BLLogin bL = new BLLogin();
            UserModel user = bL.CheckUser(txtUserName.Text, txtPassword.Text, out bool status);

            if ( status == true )
            {
                bL.InsertLastLogin(DateTime.Now, user.UserId);
                MainMenuForm mainMenu = MainMenuForm.Instance;
                mainMenu.Show();
                this.Hide();
                mainMenu.FormClosed += MainMenu_FormClosed;
            }
            //else
            //    MessageBox.Show("Utilizator sau Parola incorecta", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
            this.Close();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {

        }

        private void ChBoxVisiblePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxVisiblePassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
