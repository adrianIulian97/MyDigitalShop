namespace WinUI
{
    partial class MainInvoiceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInvoice = new System.Windows.Forms.Label();
            this.dataGridViewInvoice = new System.Windows.Forms.DataGridView();
            this.InvoiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientAddressId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StreetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StreetNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditAddressClient = new System.Windows.Forms.Button();
            this.btnAddressClient = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFilter = new System.Windows.Forms.Button();
            this.cbxClient = new System.Windows.Forms.ComboBox();
            this.lblPartner = new System.Windows.Forms.Label();
            this.dataTimeTo = new System.Windows.Forms.DateTimePicker();
            this.lblToDataDocument = new System.Windows.Forms.Label();
            this.dataTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.txtNumberDocument = new System.Windows.Forms.TextBox();
            this.lblFromDataDocument = new System.Windows.Forms.Label();
            this.lblNumberDocument = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxFromDate = new System.Windows.Forms.CheckBox();
            this.cbxToDate = new System.Windows.Forms.CheckBox();
            this.btnClientExitEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInvoice
            // 
            this.lblInvoice.AutoSize = true;
            this.lblInvoice.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoice.Location = new System.Drawing.Point(478, 77);
            this.lblInvoice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblInvoice.Name = "lblInvoice";
            this.lblInvoice.Size = new System.Drawing.Size(126, 43);
            this.lblInvoice.TabIndex = 0;
            this.lblInvoice.Text = "Facturi";
            // 
            // dataGridViewInvoice
            // 
            this.dataGridViewInvoice.AllowUserToAddRows = false;
            this.dataGridViewInvoice.AllowUserToDeleteRows = false;
            this.dataGridViewInvoice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewInvoice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceId,
            this.InvoiceNumber,
            this.InvoiceDate,
            this.ClientId,
            this.ClientAddressId,
            this.UserId,
            this.Observations,
            this.ClientName,
            this.StreetName,
            this.StreetNo,
            this.CityName,
            this.CountyName});
            this.dataGridViewInvoice.Location = new System.Drawing.Point(12, 291);
            this.dataGridViewInvoice.Name = "dataGridViewInvoice";
            this.dataGridViewInvoice.ReadOnly = true;
            this.dataGridViewInvoice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewInvoice.Size = new System.Drawing.Size(704, 214);
            this.dataGridViewInvoice.TabIndex = 7;
            // 
            // InvoiceId
            // 
            this.InvoiceId.DataPropertyName = "InvoiceId";
            this.InvoiceId.HeaderText = "InvoiceId";
            this.InvoiceId.Name = "InvoiceId";
            this.InvoiceId.ReadOnly = true;
            this.InvoiceId.Visible = false;
            // 
            // InvoiceNumber
            // 
            this.InvoiceNumber.DataPropertyName = "InvoiceNumber";
            this.InvoiceNumber.HeaderText = "Numar Factura";
            this.InvoiceNumber.Name = "InvoiceNumber";
            this.InvoiceNumber.ReadOnly = true;
            // 
            // InvoiceDate
            // 
            this.InvoiceDate.DataPropertyName = "InvoiceDate";
            this.InvoiceDate.HeaderText = "Data Factura";
            this.InvoiceDate.Name = "InvoiceDate";
            this.InvoiceDate.ReadOnly = true;
            // 
            // ClientId
            // 
            this.ClientId.DataPropertyName = "ClientId";
            this.ClientId.HeaderText = "ClientId";
            this.ClientId.Name = "ClientId";
            this.ClientId.ReadOnly = true;
            this.ClientId.Visible = false;
            // 
            // ClientAddressId
            // 
            this.ClientAddressId.DataPropertyName = "ClientAddressId";
            this.ClientAddressId.HeaderText = "ClientAddressId";
            this.ClientAddressId.Name = "ClientAddressId";
            this.ClientAddressId.ReadOnly = true;
            this.ClientAddressId.Visible = false;
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "UserId";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.Visible = false;
            // 
            // Observations
            // 
            this.Observations.DataPropertyName = "Observations";
            this.Observations.HeaderText = "Observatii";
            this.Observations.Name = "Observations";
            this.Observations.ReadOnly = true;
            // 
            // ClientName
            // 
            this.ClientName.DataPropertyName = "ClientName";
            this.ClientName.HeaderText = "Nume client";
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            // 
            // StreetName
            // 
            this.StreetName.DataPropertyName = "StreetName";
            this.StreetName.HeaderText = "Nume strada";
            this.StreetName.Name = "StreetName";
            this.StreetName.ReadOnly = true;
            // 
            // StreetNo
            // 
            this.StreetNo.DataPropertyName = "StreetNo";
            this.StreetNo.HeaderText = "Numar strada";
            this.StreetNo.Name = "StreetNo";
            this.StreetNo.ReadOnly = true;
            // 
            // CityName
            // 
            this.CityName.DataPropertyName = "CityName";
            this.CityName.HeaderText = "Oras";
            this.CityName.Name = "CityName";
            this.CityName.ReadOnly = true;
            // 
            // CountyName
            // 
            this.CountyName.DataPropertyName = "CountyName";
            this.CountyName.HeaderText = "Judet";
            this.CountyName.Name = "CountyName";
            this.CountyName.ReadOnly = true;
            // 
            // btnEditAddressClient
            // 
            this.btnEditAddressClient.BackColor = System.Drawing.Color.Olive;
            this.btnEditAddressClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAddressClient.ForeColor = System.Drawing.Color.Transparent;
            this.btnEditAddressClient.Location = new System.Drawing.Point(132, 37);
            this.btnEditAddressClient.Name = "btnEditAddressClient";
            this.btnEditAddressClient.Size = new System.Drawing.Size(75, 34);
            this.btnEditAddressClient.TabIndex = 47;
            this.btnEditAddressClient.Text = "Modifica Factura";
            this.btnEditAddressClient.UseVisualStyleBackColor = false;
            // 
            // btnAddressClient
            // 
            this.btnAddressClient.BackColor = System.Drawing.Color.Blue;
            this.btnAddressClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddressClient.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddressClient.Location = new System.Drawing.Point(16, 37);
            this.btnAddressClient.Name = "btnAddressClient";
            this.btnAddressClient.Size = new System.Drawing.Size(75, 34);
            this.btnAddressClient.TabIndex = 46;
            this.btnAddressClient.Text = "Adauga\r\nFactura";
            this.btnAddressClient.UseVisualStyleBackColor = false;
            this.btnAddressClient.Click += new System.EventHandler(this.BtnAddressClient_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.cbxToDate);
            this.panel1.Controls.Add(this.cbxFromDate);
            this.panel1.Controls.Add(this.lblFilter);
            this.panel1.Controls.Add(this.cbxClient);
            this.panel1.Controls.Add(this.lblPartner);
            this.panel1.Controls.Add(this.dataTimeTo);
            this.panel1.Controls.Add(this.lblToDataDocument);
            this.panel1.Controls.Add(this.dataTimeFrom);
            this.panel1.Controls.Add(this.txtNumberDocument);
            this.panel1.Controls.Add(this.lblFromDataDocument);
            this.panel1.Controls.Add(this.lblNumberDocument);
            this.panel1.Location = new System.Drawing.Point(12, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 247);
            this.panel1.TabIndex = 48;
            // 
            // lblFilter
            // 
            this.lblFilter.BackColor = System.Drawing.Color.Green;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.ForeColor = System.Drawing.Color.Transparent;
            this.lblFilter.Location = new System.Drawing.Point(118, 193);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(75, 34);
            this.lblFilter.TabIndex = 48;
            this.lblFilter.Text = "Filtreaza";
            this.lblFilter.UseVisualStyleBackColor = false;
            this.lblFilter.Click += new System.EventHandler(this.LblFilter_Click);
            // 
            // cbxClient
            // 
            this.cbxClient.DisplayMember = "ClientName";
            this.cbxClient.FormattingEnabled = true;
            this.cbxClient.Location = new System.Drawing.Point(153, 95);
            this.cbxClient.Name = "cbxClient";
            this.cbxClient.Size = new System.Drawing.Size(121, 27);
            this.cbxClient.TabIndex = 14;
            this.cbxClient.ValueMember = "ClientId";
            this.cbxClient.SelectedIndexChanged += new System.EventHandler(this.CbxClient_SelectedIndexChanged);
            // 
            // lblPartner
            // 
            this.lblPartner.AutoSize = true;
            this.lblPartner.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartner.Location = new System.Drawing.Point(72, 105);
            this.lblPartner.Name = "lblPartner";
            this.lblPartner.Size = new System.Drawing.Size(72, 19);
            this.lblPartner.TabIndex = 13;
            this.lblPartner.Text = "Partener:";
            // 
            // dataTimeTo
            // 
            this.dataTimeTo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTimeTo.Location = new System.Drawing.Point(153, 56);
            this.dataTimeTo.Name = "dataTimeTo";
            this.dataTimeTo.Size = new System.Drawing.Size(121, 26);
            this.dataTimeTo.TabIndex = 12;
            // 
            // lblToDataDocument
            // 
            this.lblToDataDocument.AutoSize = true;
            this.lblToDataDocument.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDataDocument.Location = new System.Drawing.Point(81, 68);
            this.lblToDataDocument.Name = "lblToDataDocument";
            this.lblToDataDocument.Size = new System.Drawing.Size(63, 19);
            this.lblToDataDocument.TabIndex = 11;
            this.lblToDataDocument.Text = "Pana la:";
            // 
            // dataTimeFrom
            // 
            this.dataTimeFrom.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTimeFrom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTimeFrom.Location = new System.Drawing.Point(153, 16);
            this.dataTimeFrom.Name = "dataTimeFrom";
            this.dataTimeFrom.Size = new System.Drawing.Size(121, 26);
            this.dataTimeFrom.TabIndex = 10;
            // 
            // txtNumberDocument
            // 
            this.txtNumberDocument.Location = new System.Drawing.Point(153, 137);
            this.txtNumberDocument.Name = "txtNumberDocument";
            this.txtNumberDocument.Size = new System.Drawing.Size(121, 26);
            this.txtNumberDocument.TabIndex = 9;
            // 
            // lblFromDataDocument
            // 
            this.lblFromDataDocument.AutoSize = true;
            this.lblFromDataDocument.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDataDocument.Location = new System.Drawing.Point(94, 28);
            this.lblFromDataDocument.Name = "lblFromDataDocument";
            this.lblFromDataDocument.Size = new System.Drawing.Size(50, 19);
            this.lblFromDataDocument.TabIndex = 8;
            this.lblFromDataDocument.Text = "De la:";
            // 
            // lblNumberDocument
            // 
            this.lblNumberDocument.AutoSize = true;
            this.lblNumberDocument.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberDocument.Location = new System.Drawing.Point(15, 147);
            this.lblNumberDocument.Name = "lblNumberDocument";
            this.lblNumberDocument.Size = new System.Drawing.Size(132, 19);
            this.lblNumberDocument.TabIndex = 7;
            this.lblNumberDocument.Text = "Numar Document:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.btnAddressClient);
            this.panel2.Controls.Add(this.btnClientExitEdit);
            this.panel2.Controls.Add(this.btnEditAddressClient);
            this.panel2.Location = new System.Drawing.Point(365, 184);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 101);
            this.panel2.TabIndex = 13;
            // 
            // cbxFromDate
            // 
            this.cbxFromDate.AutoSize = true;
            this.cbxFromDate.Location = new System.Drawing.Point(280, 19);
            this.cbxFromDate.Name = "cbxFromDate";
            this.cbxFromDate.Size = new System.Drawing.Size(15, 14);
            this.cbxFromDate.TabIndex = 49;
            this.cbxFromDate.UseVisualStyleBackColor = true;
            this.cbxFromDate.CheckedChanged += new System.EventHandler(this.CbxFromDate_CheckedChanged);
            // 
            // cbxToDate
            // 
            this.cbxToDate.AutoSize = true;
            this.cbxToDate.Location = new System.Drawing.Point(280, 65);
            this.cbxToDate.Name = "cbxToDate";
            this.cbxToDate.Size = new System.Drawing.Size(15, 14);
            this.cbxToDate.TabIndex = 50;
            this.cbxToDate.UseVisualStyleBackColor = true;
            // 
            // btnClientExitEdit
            // 
            this.btnClientExitEdit.BackColor = System.Drawing.Color.DarkRed;
            this.btnClientExitEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientExitEdit.ForeColor = System.Drawing.Color.Transparent;
            this.btnClientExitEdit.Location = new System.Drawing.Point(246, 37);
            this.btnClientExitEdit.Name = "btnClientExitEdit";
            this.btnClientExitEdit.Size = new System.Drawing.Size(75, 34);
            this.btnClientExitEdit.TabIndex = 45;
            this.btnClientExitEdit.Text = "Exit";
            this.btnClientExitEdit.UseVisualStyleBackColor = false;
            this.btnClientExitEdit.Click += new System.EventHandler(this.BtnClientExitEdit_Click);
            // 
            // MainInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 517);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewInvoice);
            this.Controls.Add(this.lblInvoice);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MainInvoiceForm";
            this.Text = "MainInvoiceForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInvoice;
        private System.Windows.Forms.DataGridView dataGridViewInvoice;
        private System.Windows.Forms.Button btnEditAddressClient;
        private System.Windows.Forms.Button btnAddressClient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dataTimeFrom;
        private System.Windows.Forms.TextBox txtNumberDocument;
        private System.Windows.Forms.Label lblFromDataDocument;
        private System.Windows.Forms.Label lblNumberDocument;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dataTimeTo;
        private System.Windows.Forms.Label lblToDataDocument;
        private System.Windows.Forms.ComboBox cbxClient;
        private System.Windows.Forms.Label lblPartner;
        private System.Windows.Forms.Button lblFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientAddressId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observations;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StreetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StreetNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountyName;
        private System.Windows.Forms.CheckBox cbxToDate;
        private System.Windows.Forms.CheckBox cbxFromDate;
        private System.Windows.Forms.Button btnClientExitEdit;
    }
}