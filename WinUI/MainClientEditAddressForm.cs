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
    public partial class MainClientEditAddressForm : Form
    {
        ClientAddressModel clientAddress = new ClientAddressModel();
        BLMainClientAddress bLClientAddress = new BLMainClientAddress();
        DataTable dataTableCounty = new DataTable();
        DataTable dataTableCity = new DataTable();
        public MainClientEditAddressForm(int clientId, int clientAddressId, int CountyId, int CityId, string StreetName, string StreetNo)
        {
            InitializeComponent();

            txtStreetName.Text = StreetName;
            txtStreetNumber.Text = StreetNo;
            clientAddress.StreetNo = StreetNo;
            clientAddress.StreetName = StreetName;
            clientAddress.ClientId = clientId;
            clientAddress.ClientAddresId = clientAddressId;
            clientAddress.CountyId = CountyId;
            clientAddress.CityId = CityId;

            cbxCounty.DataSource = bLClientAddress.ComboBoxCountyBL().DefaultView;
            cbxCounty.DisplayMember = String.Format("{0}{1}{2}", "CountyId", "Code", "CountyName");
            cbxCounty.ValueMember = "CountyId";
            cbxCounty.Enabled = true;
            cbxCounty.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCounty.SelectedIndex = CountyId-1;

            cbxCity.DataSource = bLClientAddress.ComboBoxCityBL(cbxCounty.SelectedValue.GetHashCode()).DefaultView;
            int a = cbxCounty.SelectedValue.GetHashCode();
            int b = cbxCity.SelectedValue.GetHashCode();
            cbxCity.DisplayMember = "CityName";
            cbxCity.ValueMember = "CityId";
            cbxCity.Enabled = true;
            cbxCity.SelectedIndex = clientAddress.CityId - b;

        }

        private void BtnClientExitEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClientSaveEdit_Click(object sender, EventArgs e)
        {
            if (txtStreetName.Text == clientAddress.StreetName && txtStreetNumber.Text == clientAddress.StreetNo &&
                cbxCounty.SelectedValue.GetHashCode() == clientAddress.CountyId && cbxCity.SelectedValue.GetHashCode() == clientAddress.CityId)
            {
                MessageBox.Show("Nu s-a produs nicio modificare!\nO zi buna!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                clientAddress.StreetName = txtStreetName.Text;
                clientAddress.StreetNo = txtStreetNumber.Text;
                clientAddress.CityId = cbxCity.SelectedValue.GetHashCode();
                clientAddress.CountyId = cbxCounty.SelectedValue.GetHashCode();
                bLClientAddress.ClientAddressSaveChangesBL(clientAddress);
                MessageBox.Show("Adresa a fost editata cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void CbxCounty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCounty.SelectedIndex > 0)
            {
                dataTableCity = bLClientAddress.ComboBoxCityBL(cbxCounty.SelectedValue.GetHashCode());

                /*DataRow row = dataTableCity.NewRow();
                row["CityId"] = -1;
                row["CityName"] = "--Alegeti un oras--";
                dataTableCity.Rows.InsertAt(row, 0);*/

                cbxCity.DataSource = dataTableCity;
                cbxCity.DisplayMember = "CityName";
            }
        }

        private void CbxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        

        //public class cbxCity : ComboBox
        //{
        //    this.AutoDropdown = false;
        //    this.BackColorEven = Color.White;
        //    this.BackColorOdd = Color.White;
        //    this.ColumnWidths = new List<string>();
        //    this.ColumnWidthDefault = 75;
        //    this.TotalWidth = 0;
        //    this.ColumnNames = new List<string>();
        //    this.DrawMode = DrawMode.OwnerDrawVariable;
        //    this.OwnerCell = null;
        //    ContextMenu = new ContextMenu();
        //    EditingControlValueChanged = false;
        //    public override object Clone()
        //    {
        //        var clone = (cbxCity)base.Clone();

        //        // Make sure to copy added properties.
        //        clone.ColumnNames = ColumnNames;
        //        clone.ColumnWidths = ColumnWidths;
        //        clone.EvenRowsBackColor = EvenRowsBackColor;
        //        clone.OddRowsBackColor = OddRowsBackColor;

        //        return clone;
        //    }
        //    public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        //    {
        //        base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);

        //        var editingControl = DataGridView.EditingControl as DataGridViewMultiColumnComboBoxEditingControl;
        //        // Just return if editing control is null.
        //        if (editingControl == null) return;

        //        // Set custom properties of Multi Column Combo Box.
        //        editingControl.ColumnNames = ColumnNames;
        //        editingControl.ColumnWidths = ColumnWidths;
        //        editingControl.BackColorEven = EvenRowsBackColor;
        //        editingControl.BackColorOdd = OddRowsBackColor;
        //        editingControl.OwnerCell = this;

        //        if (Value != null)
        //            editingControl.SelectedValue = Value;

        //        editingControl.AutoComplete = AutoComplete;
        //        if (!AutoComplete) return;

        //        editingControl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        //        editingControl.AutoCompleteSource = AutoCompleteSource.ListItems;
        //    }
        //}
        
    }
}
