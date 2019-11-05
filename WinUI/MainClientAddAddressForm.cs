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
    public partial class MainClientAddAddressForm : Form
    {
        ClientAddressModel clientAddress = new ClientAddressModel();
        BLMainClientAddress bLClientAddress = new BLMainClientAddress();
        DataTable dataTableCounty = new DataTable();
        DataTable dataTableCity = new DataTable();
        public MainClientAddAddressForm(int clientId)
        {
            InitializeComponent();
            dataTableCounty = bLClientAddress.ComboBoxCountyBL();
            clientAddress.ClientId = clientId;

            DataRow row = dataTableCounty.NewRow();
            row["CountyId"] = -1;
            row["CountyName"] = "--Alegeti un judet--";
            row["Code"] = "FakeAddress";
            dataTableCounty.Rows.InsertAt(row, 0);


            cbxCounty.DataSource = dataTableCounty;
            //cbxCounty.DisplayMember = "CountyId";
            //cbxCounty.ValueMember = "CountyId";
            //cbxCounty.BindingContext = this.BindingContext;


        }

        private void BtnClientExitEdit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void BtnClientSaveEdit_Click(object sender, EventArgs e)
        {
            bool statusStreetName = false, statusStreetNumber = false;
            if (!String.IsNullOrEmpty(txtStreetName.Text) && !String.IsNullOrWhiteSpace(txtStreetName.Text))
            {
                statusStreetName = true;
                clientAddress.StreetName = txtStreetName.Text;
            }
            if (!String.IsNullOrEmpty(txtStreetNumber.Text) && !String.IsNullOrWhiteSpace(txtStreetNumber.Text))
            {
                statusStreetNumber = true;
                clientAddress.StreetNo = txtStreetNumber.Text;
            }
            if (statusStreetName && statusStreetNumber && clientAddress.CityId > -1 && clientAddress.CountyId > -1)
            {
                bLClientAddress.ClientAddressSaveBL(clientAddress);
                MessageBox.Show("Adresa a fost adaugata cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Nu s-a produs nicio modificare!\nO zi buna!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
