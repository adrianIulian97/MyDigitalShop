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
    public partial class MainInvoiceAddForm : Form
    {
        InvoiceModel invoiceModelFilter = new InvoiceModel();
        BLInvoice bLInvoice = new BLInvoice();
        DataTable dataTableInvoice = new DataTable();
        public MainInvoiceAddForm()
        {
            InitializeComponent();
            Icon icon = Icon.ExtractAssociatedIcon("D:/Source Visual Studio/MyDigitalShop/favicon.ico");
            this.Icon = icon;
            dataTableInvoice = bLInvoice.ComboBoxClientBL();

            DataRow row = dataTableInvoice.NewRow();
            row["ClientId"] = -1;
            row["ClientName"] = "--Alege un partener--";
            dataTableInvoice.Rows.InsertAt(row, 0);


            cbxClient.DataSource = dataTableInvoice;
        }

        private void BtnClientExitEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxClient.SelectedIndex > 0)
            {
                invoiceModelFilter.ClientId = Convert.ToInt32(cbxClient.SelectedValue.ToString());
                dataTableInvoice = bLInvoice.ComboBoxClientAddressBL(cbxClient.SelectedValue.GetHashCode());

                DataRow row = dataTableInvoice.NewRow();
                row["CityId"] = -1;
                row["StreetName"] = "--Alegeti o locatie--";
                dataTableInvoice.Rows.InsertAt(row, 0);

                cbxClientAddress.DataSource = dataTableInvoice;
                cbxClientAddress.DisplayMember = "CityName";
            }
        }

        private void BtnClientSaveEdit_Click(object sender, EventArgs e)
        {
            bool statusNumberDocument = false, statusClient = false, statusClientAdress = false, status = false;

            if (txtNumberDocument.Text != null && !String.IsNullOrEmpty(txtNumberDocument.Text) && !String.IsNullOrWhiteSpace(txtNumberDocument.Text))
            {
                invoiceModelFilter.InvoiceNumber = txtNumberDocument.Text;
                statusNumberDocument = true;
            }
            if (Convert.ToInt32(cbxClient.SelectedValue.ToString()) > 0)
            {
                invoiceModelFilter.ClientId = cbxClient.SelectedIndex;
                statusClient = true;
            }
            if (Convert.ToInt32(cbxClientAddress.SelectedValue.ToString()) > 0)
            {
                invoiceModelFilter.ClientAddressId = cbxClientAddress.SelectedIndex;
                statusClient = true;
            }
            invoiceModelFilter.Observations = txtObservations.Text;
            invoiceModelFilter.InvoiceDate = dateTimeInvoice.Value;

            if (statusNumberDocument && statusClient) //&& statusClientAdress)
                status = true;



            if (status)
            {
                bLInvoice.AddInvoiceToDataBase(invoiceModelFilter);
                MessageBox.Show("Factura a fost adaugat cu succes!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            //else
            //{
            //    UInt32 errors = 0;
            //    string errorlbl = "";
            //    if (!statusName)
            //    {
            //        errorlbl += "nume ";
            //        errors += 1;
            //    }
            //    if (!statusSurname)
            //    {
            //        errorlbl += "prenume ";
            //        errors += 1;
            //    }
            //    if (!statusClientCode)
            //    {
            //        errorlbl += "cod ";
            //        errors += 1;
            //    }
            //    if (!statusPhoneNo)
            //    {
            //        errorlbl += "telefon ";
            //        errors += 1;
            //    }
            //    if (!statusEmail)
            //    {
            //        errorlbl += "email ";
            //        errors += 1;
            //    }
            //    errorlbl = errorlbl.Substring(0, errorlbl.Length - 1).Replace(" ", ", ");

            //    if (errors > 1)
            //        MessageBox.Show("Completati campurile " + errorlbl +
            //            " pentru a putea introduce un user.\nVa multumim.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    else
            //        MessageBox.Show("Completati campul " + errorlbl +
            //            " pentru a putea introduce un user.\nVa multumim.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void CbxClientAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxClientAddress.SelectedIndex > 0)
            {
                invoiceModelFilter.ClientAddressId = Convert.ToInt32(cbxClientAddress.SelectedValue.ToString());
            }
        }
    }
}
