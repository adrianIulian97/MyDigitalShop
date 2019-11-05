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
    public partial class MainClientForm : Form
    {
        ClientModel clientModelFilter;
        BLMainClient bLMainClient = new BLMainClient();
        public MainClientForm()
        {
            InitializeComponent();
            Icon icon = Icon.ExtractAssociatedIcon("D:/Source Visual Studio/MyDigitalShop/favicon.ico");
            this.Icon = icon;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridViewClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataTable dataTableClient = DAMain
            //dataGridViewClient.DataSource = 
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            dataGridViewClient.AutoGenerateColumns = false;
            dataGridViewClient.DataSource = bLMainClient.FilterDataTable();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            MainMenuForm.Instance.Show();
            MainMenuForm.Instance.Refresh();
            this.Close();
        }

        private void BtnAddClient_Click(object sender, EventArgs e)
        {
            MainClientAddForm mainClientAdd = new MainClientAddForm();
            mainClientAdd.Show();
            this.Hide();
            mainClientAdd.FormClosed += MainClientAdd_FormClosed;
        }

        private void MainClientAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void BtnDeleteClient_Click(object sender, EventArgs e)
        {
            if (dataGridViewClient.Rows.Count != 0 && dataGridViewClient.Rows != null)
            {

                if (MessageBox.Show("Doriti sa stergeti acest user?\nPoate are facturi in desfasurare?\nNu te-ai gandit la asta?", "Stergere client", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool status = false;
                    //status "Are facturi?"
                    status = bLMainClient.CheckInvoiceBL(Convert.ToInt32(dataGridViewClient.Rows[dataGridViewClient.CurrentRow.Index].Cells["ClientId"].Value));
                    //Decizii
                    if (status == false)
                    {
                        BLMainCLientDelete bL = new BLMainCLientDelete();
                        dataGridViewClient.AutoGenerateColumns = false;
                        dataGridViewClient.DataSource = bL.RefresDeleteClientToDataBasehData(Convert.ToInt32(dataGridViewClient.Rows[dataGridViewClient.CurrentRow.Index].Cells["ClientId"].Value));
                    }
                    else
                    {
                        MessageBox.Show("Nu se poate. Clientul are facturi.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("Nu ati selectat niciun client pentru stergere!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEditClient_Click(object sender, EventArgs e)
        {
            if (dataGridViewClient.Rows.Count != 0 && dataGridViewClient.Rows != null)
            {
                MainClientEditForm mainClientEdit = new MainClientEditForm(Convert.ToInt32(dataGridViewClient.Rows[dataGridViewClient.CurrentRow.Index].Cells["ClientId"].Value));
                mainClientEdit.Show();
                this.Hide();
                mainClientEdit.FormClosed += MainClientEdit_FormClosed;
            }
            else
            {
                MessageBox.Show("Nu ati selectat niciun client pentru editare!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainClientEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            BLMainCLientEdit bL = new BLMainCLientEdit();
            dataGridViewClient.AutoGenerateColumns = false;
            dataGridViewClient.DataSource = bL.RefreshDataClientEdit();
        }

        private void BtnFilterWithParameters_Click(object sender, EventArgs e)
        {
            bool status = false, statusEmail = false;
            clientModelFilter = new ClientModel();
            if (!String.IsNullOrWhiteSpace(txtClientName.Text) && !String.IsNullOrEmpty(txtClientName.Text))
            {
                clientModelFilter.ClientName = String.Concat("\'" + txtClientName.Text + "\'");
                status = true;
            }
            else
            {
                clientModelFilter.ClientName = "null";
            }
            if (!String.IsNullOrWhiteSpace(txtSecondName.Text) && !String.IsNullOrEmpty(txtSecondName.Text))
            {
                clientModelFilter.ClientSurname = String.Concat("\'" + txtSecondName.Text + "\'");
                status = true;
            }
            else
            {
                clientModelFilter.ClientSurname = "null";
            }
            if (!String.IsNullOrWhiteSpace(txtClientCode.Text) && !String.IsNullOrEmpty(txtClientCode.Text))
            {
                clientModelFilter.ClientCode = String.Concat("\'" + txtClientCode.Text + "\'");
                status = true;
            }
            else
            {
                clientModelFilter.ClientCode = "null";
            }
            if (!String.IsNullOrWhiteSpace(txtClientPhoneNumber.Text) && !String.IsNullOrEmpty(txtClientPhoneNumber.Text))
            {
                clientModelFilter.PhoneNo = String.Concat("\'" + txtClientPhoneNumber.Text + "\'");
                status = true;
            }
            else
            {
                clientModelFilter.PhoneNo = "null";
            }
            if (!String.IsNullOrWhiteSpace(txtClientEmail.Text) && !String.IsNullOrEmpty(txtClientEmail.Text))
            {
                if (IsValidEmail(txtClientEmail.Text))
                {
                    clientModelFilter.Email = txtClientEmail.Text;
                    status = true;
                }
                else
                {
                    //client.Email = "adresaEmail@domeniu";
                    //txtEmail.Text = "adresaEmail@domeniu";
                    MessageBox.Show("Adresa de mail nu este valida!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    statusEmail = true;
                }
            }
            else
            {
                clientModelFilter.Email = "null";
            }

            if (status == true)
            {
                dataGridViewClient.DataSource = bLMainClient.FilterDataWithParametersTable(clientModelFilter);
            }
            else
            {
                if (!statusEmail)
                    dataGridViewClient.DataSource = bLMainClient.FilterDataTable();
            }
        }

        private void DataGridViewClient_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridViewClient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewClient.Rows.Count != 0 && dataGridViewClient.Rows != null)
            {
                MainClientEditForm mainClientEdit = new MainClientEditForm(Convert.ToInt32(dataGridViewClient.Rows[dataGridViewClient.CurrentRow.Index].Cells["ClientId"].Value));
                mainClientEdit.Show();
                this.Hide();
                mainClientEdit.FormClosed += MainClientEdit_FormClosed;
            }
            else
            {
                MessageBox.Show("Nu ati selectat niciun client pentru editare!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtClientPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                //MessageBox.Show("Doar numere!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
