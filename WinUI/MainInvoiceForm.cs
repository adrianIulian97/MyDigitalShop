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
    public partial class MainInvoiceForm : Form
    {
        InvoiceModel invoiceModelFilter = new InvoiceModel();
        BLInvoice bLInvoice = new BLInvoice();
        DataTable dataTableClient = new DataTable();
        public MainInvoiceForm()
        {
            InitializeComponent();
            Icon icon = Icon.ExtractAssociatedIcon("D:/Source Visual Studio/MyDigitalShop/favicon.ico");
            this.Icon = icon;
            dataTableClient = bLInvoice.ComboBoxClientBL();

            DataRow row = dataTableClient.NewRow();
            row["ClientId"] = -1;
            row["ClientName"] = "";
            dataTableClient.Rows.InsertAt(row, 0);


            cbxClient.DataSource = dataTableClient;
        }
        private void BtnClientExitEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LblFilter_Click(object sender, EventArgs e)
        {
            //Search
            dataGridViewInvoice.AutoGenerateColumns = false;
            dataGridViewInvoice.DataSource = bLInvoice.FilterDataTable();
            //Filter
            bool status = false, statusEmail = false;
            invoiceModelFilter = new InvoiceModel();
            if (!String.IsNullOrWhiteSpace(txtNumberDocument.Text) && !String.IsNullOrEmpty(txtNumberDocument.Text))
            {
                invoiceModelFilter.InvoiceNumber = String.Concat("\'" + txtNumberDocument.Text + "\'");
                status = true;
            }
            else
            {
                invoiceModelFilter.InvoiceNumber = "null";
            }
            if (Convert.ToInt32(cbxClient.SelectedValue.ToString()) > 0)
            {
                invoiceModelFilter.ClientId = Convert.ToInt32(cbxClient.SelectedValue.ToString());
                status = true;
            }
            else
            {
                invoiceModelFilter.ClientId = 0;
            }

            if (status == true)
            {
                DateTime varFromDate = new DateTime(1990, 12, 04); 
                DateTime varToDate = new DateTime(2190, 12, 04);
                if (cbxFromDate.Checked && cbxToDate.Checked)
                    dataGridViewInvoice.DataSource = bLInvoice.FilterDataWithParametersTable(invoiceModelFilter.ClientId, invoiceModelFilter.InvoiceNumber, dataTimeFrom.Value, dataTimeTo.Value);
                if (!cbxFromDate.Checked && cbxToDate.Checked)
                    dataGridViewInvoice.DataSource = bLInvoice.FilterDataWithParametersTable(invoiceModelFilter.ClientId, invoiceModelFilter.InvoiceNumber, varFromDate, dataTimeTo.Value);
                if (cbxFromDate.Checked && !cbxToDate.Checked)
                    dataGridViewInvoice.DataSource = bLInvoice.FilterDataWithParametersTable(invoiceModelFilter.ClientId, invoiceModelFilter.InvoiceNumber, dataTimeFrom.Value, varToDate);
                if (!cbxFromDate.Checked && !cbxToDate.Checked)
                    dataGridViewInvoice.DataSource = bLInvoice.FilterDataWithParametersTable(invoiceModelFilter.ClientId, invoiceModelFilter.InvoiceNumber, varFromDate, varToDate);
            }
            else
            {
                if (!statusEmail)
                    dataGridViewInvoice.DataSource = bLInvoice.FilterDataTable();
            }
        }

        private void CbxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxClient.SelectedIndex > 0)
            {
                invoiceModelFilter.ClientId = Convert.ToInt32(cbxClient.SelectedValue.ToString());
            }
        }

        private void CbxFromDate_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnAddressClient_Click(object sender, EventArgs e)
        {
            MainInvoiceAddForm mainInvoice = new MainInvoiceAddForm();
            mainInvoice.Show();
            this.Hide();
            mainInvoice.FormClosed += MainInvoice_FormClosed;
        }

        private void MainInvoice_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}

