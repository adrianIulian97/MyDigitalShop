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
    public partial class MainClientAddForm : Form
    {
        ClientAddressModel clientAddress = new ClientAddressModel();
        BLMainClientAddress bLClientAddress = new BLMainClientAddress();
        DataTable dataTableCounty = new DataTable();
        DataTable dataTableCity = new DataTable();
        private bool buttonExitWasClicked = false;
        public MainClientAddForm()
        {
            InitializeComponent();
            Icon icon = Icon.ExtractAssociatedIcon("D:/Source Visual Studio/MyDigitalShop/favicon.ico");
            this.Icon = icon;
            dataTableCounty = bLClientAddress.ComboBoxCountyBL();
            //clientAddress.ClientId = clientId;

            DataRow row = dataTableCounty.NewRow();
            row["CountyId"] = -1;
            row["CountyName"] = "--Alegeti un judet--";
            row["Code"] = "FakeAddress";
            dataTableCounty.Rows.InsertAt(row, 0);


            cbxCounty.DataSource = dataTableCounty;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (buttonExitWasClicked == true)
            {
                e.Cancel = true;
                buttonExitWasClicked = false;
            }
        }

        private void BtnClientExit_Click(object sender, EventArgs e)
        {
            //buttonExitWasClicked = true;
            this.Close();
        }

        private void BtnClientSave_Click(object sender, EventArgs e)
        {
            BLMainClientAdd bL = new BLMainClientAdd();
            ClientModel client = new ClientModel();
            bool statusSaveClient = false, statusName = false, statusSurname = false, statusClientCode = false, statusPhoneNo = false, statusEmail = false,
                statusStreetName = false, statusStreetNumber = false, statusCounty = false, statusCity = false, statusSaveAll = false;
            

            if (txtName.Text != null && !String.IsNullOrEmpty(txtName.Text) && !String.IsNullOrWhiteSpace(txtName.Text))
            {
                client.ClientName = txtName.Text;
                statusName = true;
            }
            if (txtSecondName.Text != null && !String.IsNullOrEmpty(txtSecondName.Text) && !String.IsNullOrWhiteSpace(txtSecondName.Text))
            {
                client.ClientSurname = txtSecondName.Text;
                statusSurname = true;
            }
            if (txtClientCode.Text != null && !String.IsNullOrEmpty(txtClientCode.Text) && !String.IsNullOrWhiteSpace(txtClientCode.Text))
            {
                client.ClientCode = txtClientCode.Text;
                statusClientCode = true;
            }
            if (txtClientPhone.Text != null && !String.IsNullOrEmpty(txtClientPhone.Text) && !String.IsNullOrWhiteSpace(txtClientPhone.Text))
            {
                client.PhoneNo = txtClientPhone.Text;
                statusPhoneNo = true;
            }
            if (txtEmail.Text != null && !String.IsNullOrEmpty(txtEmail.Text) && !String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                if (IsValidEmail(txtEmail.Text))
                {
                    client.Email = txtEmail.Text;
                    statusEmail = true;
                }
                else
                {
                    client.Email = "adresaEmail@domeniu";
                    txtEmail.Text = "adresaEmail@domeniu";
                    MessageBox.Show("Adresa de mail nu este valida!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (!String.IsNullOrEmpty(txtClientStreetName.Text) && !String.IsNullOrWhiteSpace(txtClientStreetName.Text))
            {
                statusStreetName = true;
                clientAddress.StreetName = txtClientStreetName.Text;
            }
            if (!String.IsNullOrEmpty(txtClientStreetNumber.Text) && !String.IsNullOrWhiteSpace(txtClientStreetNumber.Text))
            {
                statusStreetNumber = true;
                clientAddress.StreetNo = txtClientStreetNumber.Text;
            }

            if (statusName && statusSurname && statusClientCode && statusPhoneNo && statusEmail)
                statusSaveClient = true;
            if (statusName && statusSurname && statusClientCode && statusPhoneNo && statusEmail && statusCounty && statusCity && statusStreetName && statusStreetNumber)
                statusSaveAll = true;



            if (statusSaveAll)
            {
                if (bL.CheckClienCodeIsUnicBL(client.ClientCode))
                {
                    //Client
                    bL.AddClientToDataBase(client);
                    if (false == false)
                    {
                        MessageBox.Show("Userul a fost adaugat cu succes!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    //ClientAddress
                    //function to get ClientId 
                    clientAddress.ClientId = bLClientAddress.ClientGetCliendIdBL(client);
                    bLClientAddress.ClientAddressSaveBL(clientAddress);
                    MessageBox.Show("Adresa a fost adaugata cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Codul trebuie sa fie unic!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                UInt32 errors = 0;
                string errorlbl = "";
                if (!statusName)
                {
                    errorlbl += "nume ";
                    errors += 1;
                }
                if (!statusSurname)
                {
                    errorlbl += "prenume ";
                    errors += 1;
                }
                if (!statusClientCode)
                {
                    errorlbl += "cod ";
                    errors += 1;
                }
                if (!statusPhoneNo)
                {
                    errorlbl += "telefon ";
                    errors += 1;
                }
                if (!statusEmail)
                {
                    errorlbl += "email ";
                    errors += 1;
                }
                errorlbl = errorlbl.Substring(0, errorlbl.Length - 1).Replace(" ", ", ");

                if (errors > 1)
                    MessageBox.Show("Completati campurile " + errorlbl +
                        " pentru a putea introduce un user.\nVa multumim.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Completati campul " + errorlbl +
                        " pentru a putea introduce un user.\nVa multumim.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbxCounty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCounty.SelectedIndex > 0)
            {
                dataTableCity = bLClientAddress.ComboBoxCityBL(cbxCounty.SelectedValue.GetHashCode());

                DataRow row = dataTableCity.NewRow();
                row["CityId"] = -1;
                row["CityName"] = "--Alegeti un oras--";
                dataTableCity.Rows.InsertAt(row, 0);

                cbxCity.DataSource = dataTableCity;
                cbxCity.DisplayMember = "CityName";
            }
        }

        private void CbxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            clientAddress.CountyId = cbxCounty.SelectedValue.GetHashCode();
            clientAddress.CityId = cbxCity.SelectedValue.GetHashCode();
        }

        private void TxtClientPhone_KeyPress(object sender, KeyPressEventArgs e)
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
