namespace WinUI
{
    partial class MainClientEditForm
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
            this.btnClientExitEdit = new System.Windows.Forms.Button();
            this.btnClientSaveEdit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.txtClientCode = new System.Windows.Forms.TextBox();
            this.lblClientCode = new System.Windows.Forms.Label();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.dataGridViewAddressClient = new System.Windows.Forms.DataGridView();
            this.CountyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StreetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StreetNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientAddressid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddressClient = new System.Windows.Forms.Button();
            this.btnEditAddressClient = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddressClient)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClientExitEdit
            // 
            this.btnClientExitEdit.BackColor = System.Drawing.Color.DarkRed;
            this.btnClientExitEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientExitEdit.ForeColor = System.Drawing.Color.Transparent;
            this.btnClientExitEdit.Location = new System.Drawing.Point(464, 29);
            this.btnClientExitEdit.Name = "btnClientExitEdit";
            this.btnClientExitEdit.Size = new System.Drawing.Size(75, 34);
            this.btnClientExitEdit.TabIndex = 39;
            this.btnClientExitEdit.Text = "Exit";
            this.btnClientExitEdit.UseVisualStyleBackColor = false;
            this.btnClientExitEdit.Click += new System.EventHandler(this.BtnClientExitEdit_Click);
            // 
            // btnClientSaveEdit
            // 
            this.btnClientSaveEdit.BackColor = System.Drawing.Color.Green;
            this.btnClientSaveEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientSaveEdit.ForeColor = System.Drawing.Color.Transparent;
            this.btnClientSaveEdit.Location = new System.Drawing.Point(464, 112);
            this.btnClientSaveEdit.Name = "btnClientSaveEdit";
            this.btnClientSaveEdit.Size = new System.Drawing.Size(75, 34);
            this.btnClientSaveEdit.TabIndex = 38;
            this.btnClientSaveEdit.Text = "Save";
            this.btnClientSaveEdit.UseVisualStyleBackColor = false;
            this.btnClientSaveEdit.Click += new System.EventHandler(this.BtnClientSaveEdit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txtPhoneNo);
            this.panel1.Controls.Add(this.lblTitle1);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtSecondName);
            this.panel1.Controls.Add(this.txtClientCode);
            this.panel1.Controls.Add(this.lblClientCode);
            this.panel1.Controls.Add(this.lblSecondName);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblPhoneNumber);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 174);
            this.panel1.TabIndex = 37;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(324, 93);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(108, 20);
            this.txtPhoneNo.TabIndex = 33;
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.Location = new System.Drawing.Point(35, 7);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(167, 26);
            this.lblTitle1.TabIndex = 32;
            this.lblTitle1.Text = "Informatii Client";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(107, 56);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(108, 20);
            this.txtName.TabIndex = 13;
            // 
            // txtSecondName
            // 
            this.txtSecondName.Location = new System.Drawing.Point(107, 96);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(108, 20);
            this.txtSecondName.TabIndex = 14;
            // 
            // txtClientCode
            // 
            this.txtClientCode.Location = new System.Drawing.Point(324, 53);
            this.txtClientCode.Name = "txtClientCode";
            this.txtClientCode.Size = new System.Drawing.Size(108, 20);
            this.txtClientCode.TabIndex = 15;
            // 
            // lblClientCode
            // 
            this.lblClientCode.AutoSize = true;
            this.lblClientCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCode.Location = new System.Drawing.Point(235, 57);
            this.lblClientCode.Name = "lblClientCode";
            this.lblClientCode.Size = new System.Drawing.Size(83, 16);
            this.lblClientCode.TabIndex = 16;
            this.lblClientCode.Text = "Cod Client:";
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondName.Location = new System.Drawing.Point(18, 100);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(73, 16);
            this.lblSecondName.TabIndex = 17;
            this.lblSecondName.Text = "Prenume:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(18, 60);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 16);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Nume:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(107, 138);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(108, 20);
            this.txtEmail.TabIndex = 20;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(18, 138);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 16);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(235, 97);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(65, 16);
            this.lblPhoneNumber.TabIndex = 22;
            this.lblPhoneNumber.Text = "Telefon:";
            // 
            // dataGridViewAddressClient
            // 
            this.dataGridViewAddressClient.AllowUserToAddRows = false;
            this.dataGridViewAddressClient.AllowUserToDeleteRows = false;
            this.dataGridViewAddressClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddressClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CountyName,
            this.CityName,
            this.StreetName,
            this.StreetNo,
            this.ClientAddressid,
            this.ClientId,
            this.CityId,
            this.CountyId});
            this.dataGridViewAddressClient.Location = new System.Drawing.Point(12, 192);
            this.dataGridViewAddressClient.Name = "dataGridViewAddressClient";
            this.dataGridViewAddressClient.ReadOnly = true;
            this.dataGridViewAddressClient.Size = new System.Drawing.Size(446, 150);
            this.dataGridViewAddressClient.TabIndex = 40;
            this.dataGridViewAddressClient.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewAddressClient_CellDoubleClick);
            // 
            // CountyName
            // 
            this.CountyName.DataPropertyName = "CountyName";
            this.CountyName.HeaderText = "Judet";
            this.CountyName.Name = "CountyName";
            this.CountyName.ReadOnly = true;
            // 
            // CityName
            // 
            this.CityName.DataPropertyName = "CityName";
            this.CityName.HeaderText = "Oras";
            this.CityName.Name = "CityName";
            this.CityName.ReadOnly = true;
            // 
            // StreetName
            // 
            this.StreetName.DataPropertyName = "StreetName";
            this.StreetName.HeaderText = "Strada";
            this.StreetName.Name = "StreetName";
            this.StreetName.ReadOnly = true;
            // 
            // StreetNo
            // 
            this.StreetNo.DataPropertyName = "StreetNo";
            this.StreetNo.HeaderText = "Numar";
            this.StreetNo.Name = "StreetNo";
            this.StreetNo.ReadOnly = true;
            // 
            // ClientAddressid
            // 
            this.ClientAddressid.DataPropertyName = "ClientAddressId";
            this.ClientAddressid.HeaderText = "ClientAddressid";
            this.ClientAddressid.Name = "ClientAddressid";
            this.ClientAddressid.ReadOnly = true;
            this.ClientAddressid.Visible = false;
            // 
            // ClientId
            // 
            this.ClientId.DataPropertyName = "ClientId";
            this.ClientId.HeaderText = "ClientId";
            this.ClientId.Name = "ClientId";
            this.ClientId.ReadOnly = true;
            this.ClientId.Visible = false;
            // 
            // CityId
            // 
            this.CityId.DataPropertyName = "CityId";
            this.CityId.HeaderText = "CityId";
            this.CityId.Name = "CityId";
            this.CityId.ReadOnly = true;
            this.CityId.Visible = false;
            // 
            // CountyId
            // 
            this.CountyId.DataPropertyName = "CountyId";
            this.CountyId.HeaderText = "CountyId";
            this.CountyId.Name = "CountyId";
            this.CountyId.ReadOnly = true;
            this.CountyId.Visible = false;
            // 
            // btnAddressClient
            // 
            this.btnAddressClient.BackColor = System.Drawing.Color.Blue;
            this.btnAddressClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddressClient.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddressClient.Location = new System.Drawing.Point(464, 211);
            this.btnAddressClient.Name = "btnAddressClient";
            this.btnAddressClient.Size = new System.Drawing.Size(75, 34);
            this.btnAddressClient.TabIndex = 41;
            this.btnAddressClient.Text = "Adauga\r\nAdresa";
            this.btnAddressClient.UseVisualStyleBackColor = false;
            this.btnAddressClient.Click += new System.EventHandler(this.BtnAddressClient_Click);
            // 
            // btnEditAddressClient
            // 
            this.btnEditAddressClient.BackColor = System.Drawing.Color.Olive;
            this.btnEditAddressClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAddressClient.ForeColor = System.Drawing.Color.Transparent;
            this.btnEditAddressClient.Location = new System.Drawing.Point(464, 281);
            this.btnEditAddressClient.Name = "btnEditAddressClient";
            this.btnEditAddressClient.Size = new System.Drawing.Size(75, 34);
            this.btnEditAddressClient.TabIndex = 43;
            this.btnEditAddressClient.Text = "Modifica Adresa";
            this.btnEditAddressClient.UseVisualStyleBackColor = false;
            this.btnEditAddressClient.Click += new System.EventHandler(this.BtnEditAddressClient_Click);
            // 
            // MainClientEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 358);
            this.Controls.Add(this.btnEditAddressClient);
            this.Controls.Add(this.btnAddressClient);
            this.Controls.Add(this.dataGridViewAddressClient);
            this.Controls.Add(this.btnClientExitEdit);
            this.Controls.Add(this.btnClientSaveEdit);
            this.Controls.Add(this.panel1);
            this.Name = "MainClientEditForm";
            this.Text = "Modifica client";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddressClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClientExitEdit;
        private System.Windows.Forms.Button btnClientSaveEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.TextBox txtClientCode;
        private System.Windows.Forms.Label lblClientCode;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.DataGridView dataGridViewAddressClient;
        private System.Windows.Forms.Button btnAddressClient;
        private System.Windows.Forms.Button btnEditAddressClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StreetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StreetNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientAddressid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountyId;
    }
}