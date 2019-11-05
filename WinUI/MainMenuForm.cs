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
    public partial class MainMenuForm : Form
    {
        private static MainMenuForm instance;
        private MainMenuForm()
        {
            InitializeComponent();
            Icon icon = Icon.ExtractAssociatedIcon("D:/Source Visual Studio/MyDigitalShop/favicon.ico");
            this.Icon = icon;
        }

        public static MainMenuForm Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MainMenuForm();
                }
                return instance;
            }
        }

        //public MainMenuForm()
        //{
        //    InitializeComponent();
        //    Icon icon = Icon.ExtractAssociatedIcon("C:/Users/aruscuta/Desktop/favicon.ico");
        //    this.Icon = icon;
        //}

        private void Button2_Click(object sender, EventArgs e)
        {
            if (true == true)
            {
                MainClientForm mainClient = new MainClientForm();
                mainClient.Show();
                this.Hide();
                mainClient.FormClosed += MainClient_FormClosed;
            }
        }

        private void BtnInvoice_Click(object sender, EventArgs e)
        {
            MainInvoiceForm mainInvoice = new MainInvoiceForm();
            mainInvoice.Show();
            this.Hide();
            mainInvoice.FormClosed += MainInvoice_FormClosed;
        }

        private void BtnItem_Click(object sender, EventArgs e)
        {
            MainItemForm mainItem = new MainItemForm();
            mainItem.Show();
            this.Hide();
            mainItem.FormClosed += MainItem_FormClosed;
        }

        private void MainItem_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
            this.Close();
        }

        private void MainClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
            this.Close();
        }

        private void MainInvoice_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
            this.Close();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
