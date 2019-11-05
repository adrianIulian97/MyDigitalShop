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
    public partial class MainClientEditForm : Form
    {
        private int indexModifyClient;
        ClientModel client = new ClientModel();
        BLMainCLientEdit bLClientEdit = new BLMainCLientEdit();

        /*public MainClientEditForm()
        {
            InitializeComponent();
            Icon icon = Icon.ExtractAssociatedIcon("C:/Users/aruscuta/Desktop/favicon.ico");
            this.Icon = icon;
        }*/
        public MainClientEditForm(int indexModifyClient)
        {
            InitializeComponent();
            Icon icon = Icon.ExtractAssociatedIcon("D:/Source Visual Studio/MyDigitalShop/favicon.ico");
            this.Icon = icon;
            this.indexModifyClient = indexModifyClient;
            client = bLClientEdit.ClientEditSource(indexModifyClient);
            txtName.Text = client.ClientName;
            txtSecondName.Text = client.ClientSurname;
            txtClientCode.Text = client.ClientCode;
            txtPhoneNo.Text = client.PhoneNo;
            txtEmail.Text = client.Email;

            dataGridViewAddressClient.AutoGenerateColumns = false;
            dataGridViewAddressClient.DataSource = bLClientEdit.FilterAddressClientDataTableBL(client.ClientId);
        }

        private void BtnClientExitEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClientSaveEdit_Click(object sender, EventArgs e)
        {
            bool status = false;
            if (txtName.Text != client.ClientName)
            {
                client.ClientName = txtName.Text;
                status = true;
            }
            if (txtSecondName.Text != client.ClientSurname)
            {
                client.ClientSurname = txtSecondName.Text;
                status = true;
            }
            if (txtClientCode.Text != client.ClientCode)
            {
                client.ClientCode = txtClientCode.Text;
                status = true;
            }
            if (txtPhoneNo.Text != client.PhoneNo)
            {
                client.PhoneNo = txtPhoneNo.Text;
                status = true;
            }
            if (txtEmail.Text != this.client.Email)
            {
                client.Email = txtEmail.Text;
                status = true;
            }

            if (status == true)
            {
                bLClientEdit.ClientEditDestination(client);
                MessageBox.Show("Userul a fost editat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void BtnSearchAddressClient_Click(object sender, EventArgs e)
        {
            dataGridViewAddressClient.AutoGenerateColumns = false;
            dataGridViewAddressClient.DataSource = bLClientEdit.FilterAddressClientDataTableBL(client.ClientId);
        }

        private void BtnAddressClient_Click(object sender, EventArgs e)
        {
            MainClientAddAddressForm addAddressForm = new MainClientAddAddressForm(client.ClientId);
            addAddressForm.Show();
            this.Hide();
            addAddressForm.FormClosed += AddAddressForm_FormClosed;
        }

        private void AddAddressForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            dataGridViewAddressClient.DataSource = bLClientEdit.FilterAddressClientDataTableBL(client.ClientId);
        }

        private void BtnEditAddressClient_Click(object sender, EventArgs e)
        {
            if (dataGridViewAddressClient.Rows.Count != 0 && dataGridViewAddressClient.Rows != null)
            {
                MainClientEditAddressForm editAddressForm = new MainClientEditAddressForm(client.ClientId,
                    Convert.ToInt32(dataGridViewAddressClient.Rows[dataGridViewAddressClient.CurrentRow.Index].Cells["ClientAddressId"].Value),
                    Convert.ToInt32(dataGridViewAddressClient.Rows[dataGridViewAddressClient.CurrentRow.Index].Cells["CountyId"].Value),
                    Convert.ToInt32(dataGridViewAddressClient.Rows[dataGridViewAddressClient.CurrentRow.Index].Cells["CityId"].Value),
                    dataGridViewAddressClient.Rows[dataGridViewAddressClient.CurrentRow.Index].Cells["StreetName"].Value.ToString(),
                    dataGridViewAddressClient.Rows[dataGridViewAddressClient.CurrentRow.Index].Cells["StreetNo"].Value.ToString()
                    );
                editAddressForm.Show();
                this.Hide();
                editAddressForm.FormClosed += EditAddressForm_FormClosed;
            }
        }

        private void EditAddressForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            dataGridViewAddressClient.DataSource = bLClientEdit.FilterAddressClientDataTableBL(client.ClientId);
        }

        private void DataGridViewAddressClient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewAddressClient.Rows.Count != 0 && dataGridViewAddressClient.Rows != null)
            {
                MainClientEditAddressForm editAddressForm = new MainClientEditAddressForm(client.ClientId,
                    Convert.ToInt32(dataGridViewAddressClient.Rows[dataGridViewAddressClient.CurrentRow.Index].Cells["ClientAddressId"].Value),
                    Convert.ToInt32(dataGridViewAddressClient.Rows[dataGridViewAddressClient.CurrentRow.Index].Cells["CountyId"].Value),
                    Convert.ToInt32(dataGridViewAddressClient.Rows[dataGridViewAddressClient.CurrentRow.Index].Cells["CityId"].Value),
                    dataGridViewAddressClient.Rows[dataGridViewAddressClient.CurrentRow.Index].Cells["StreetName"].Value.ToString(),
                    dataGridViewAddressClient.Rows[dataGridViewAddressClient.CurrentRow.Index].Cells["StreetNo"].Value.ToString()
                    );
                editAddressForm.Show();
                this.Hide();
                editAddressForm.FormClosed += EditAddressForm_FormClosed;
            }
        }
    }
}
