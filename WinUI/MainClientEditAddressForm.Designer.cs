namespace WinUI
{
    partial class MainClientEditAddressForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxCity = new System.Windows.Forms.ComboBox();
            this.cbxCounty = new System.Windows.Forms.ComboBox();
            this.lblClientAddress = new System.Windows.Forms.Label();
            this.txtStreetNumber = new System.Windows.Forms.TextBox();
            this.txtStreetName = new System.Windows.Forms.TextBox();
            this.lblStreetName = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblStreetNumber = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClientExitEdit
            // 
            this.btnClientExitEdit.BackColor = System.Drawing.Color.DarkRed;
            this.btnClientExitEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientExitEdit.ForeColor = System.Drawing.Color.Transparent;
            this.btnClientExitEdit.Location = new System.Drawing.Point(228, 251);
            this.btnClientExitEdit.Name = "btnClientExitEdit";
            this.btnClientExitEdit.Size = new System.Drawing.Size(75, 34);
            this.btnClientExitEdit.TabIndex = 44;
            this.btnClientExitEdit.Text = "Exit";
            this.btnClientExitEdit.UseVisualStyleBackColor = false;
            this.btnClientExitEdit.Click += new System.EventHandler(this.BtnClientExitEdit_Click);
            // 
            // btnClientSaveEdit
            // 
            this.btnClientSaveEdit.BackColor = System.Drawing.Color.Green;
            this.btnClientSaveEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientSaveEdit.ForeColor = System.Drawing.Color.Transparent;
            this.btnClientSaveEdit.Location = new System.Drawing.Point(147, 251);
            this.btnClientSaveEdit.Name = "btnClientSaveEdit";
            this.btnClientSaveEdit.Size = new System.Drawing.Size(75, 34);
            this.btnClientSaveEdit.TabIndex = 43;
            this.btnClientSaveEdit.Text = "Save";
            this.btnClientSaveEdit.UseVisualStyleBackColor = false;
            this.btnClientSaveEdit.Click += new System.EventHandler(this.BtnClientSaveEdit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.cbxCounty);
            this.panel2.Controls.Add(this.lblClientAddress);
            this.panel2.Controls.Add(this.txtStreetNumber);
            this.panel2.Controls.Add(this.txtStreetName);
            this.panel2.Controls.Add(this.lblStreetName);
            this.panel2.Controls.Add(this.lblCounty);
            this.panel2.Controls.Add(this.lblStreetNumber);
            this.panel2.Controls.Add(this.lblCity);
            this.panel2.Controls.Add(this.cbxCity);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 219);
            this.panel2.TabIndex = 42;
            // 
            // cbxCity
            // 
            this.cbxCity.DisplayMember = "CityName";
            this.cbxCity.FormattingEnabled = true;
            this.cbxCity.Location = new System.Drawing.Point(115, 91);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.Size = new System.Drawing.Size(230, 21);
            this.cbxCity.TabIndex = 33;
            this.cbxCity.ValueMember = "CityId";
            this.cbxCity.SelectedIndexChanged += new System.EventHandler(this.CbxCity_SelectedIndexChanged);
            // 
            // cbxCounty
            // 
            this.cbxCounty.DisplayMember = "CountyName";
            this.cbxCounty.FormattingEnabled = true;
            this.cbxCounty.Location = new System.Drawing.Point(115, 51);
            this.cbxCounty.Name = "cbxCounty";
            this.cbxCounty.Size = new System.Drawing.Size(230, 21);
            this.cbxCounty.TabIndex = 32;
            this.cbxCounty.ValueMember = "CountyId";
            this.cbxCounty.SelectedIndexChanged += new System.EventHandler(this.CbxCounty_SelectedIndexChanged);
            // 
            // lblClientAddress
            // 
            this.lblClientAddress.AutoSize = true;
            this.lblClientAddress.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientAddress.Location = new System.Drawing.Point(66, 7);
            this.lblClientAddress.Name = "lblClientAddress";
            this.lblClientAddress.Size = new System.Drawing.Size(140, 26);
            this.lblClientAddress.TabIndex = 24;
            this.lblClientAddress.Text = "Adresa Client";
            // 
            // txtStreetNumber
            // 
            this.txtStreetNumber.Location = new System.Drawing.Point(115, 179);
            this.txtStreetNumber.Name = "txtStreetNumber";
            this.txtStreetNumber.Size = new System.Drawing.Size(230, 20);
            this.txtStreetNumber.TabIndex = 31;
            // 
            // txtStreetName
            // 
            this.txtStreetName.Location = new System.Drawing.Point(115, 139);
            this.txtStreetName.Name = "txtStreetName";
            this.txtStreetName.Size = new System.Drawing.Size(230, 20);
            this.txtStreetName.TabIndex = 30;
            // 
            // lblStreetName
            // 
            this.lblStreetName.AutoSize = true;
            this.lblStreetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetName.Location = new System.Drawing.Point(11, 139);
            this.lblStreetName.Name = "lblStreetName";
            this.lblStreetName.Size = new System.Drawing.Size(58, 16);
            this.lblStreetName.TabIndex = 25;
            this.lblStreetName.Text = "Strada:";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounty.Location = new System.Drawing.Point(11, 56);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(50, 16);
            this.lblCounty.TabIndex = 26;
            this.lblCounty.Text = "Judet:";
            // 
            // lblStreetNumber
            // 
            this.lblStreetNumber.AutoSize = true;
            this.lblStreetNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetNumber.Location = new System.Drawing.Point(11, 179);
            this.lblStreetNumber.Name = "lblStreetNumber";
            this.lblStreetNumber.Size = new System.Drawing.Size(82, 16);
            this.lblStreetNumber.TabIndex = 28;
            this.lblStreetNumber.Text = "Nr. Strada:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(11, 96);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(45, 16);
            this.lblCity.TabIndex = 27;
            this.lblCity.Text = "Oras:";
            // 
            // MainClientEditAddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 297);
            this.Controls.Add(this.btnClientExitEdit);
            this.Controls.Add(this.btnClientSaveEdit);
            this.Controls.Add(this.panel2);
            this.Name = "MainClientEditAddressForm";
            this.Text = "Editare Adresa Client";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClientExitEdit;
        private System.Windows.Forms.Button btnClientSaveEdit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbxCity;
        private System.Windows.Forms.ComboBox cbxCounty;
        private System.Windows.Forms.Label lblClientAddress;
        private System.Windows.Forms.TextBox txtStreetNumber;
        private System.Windows.Forms.TextBox txtStreetName;
        private System.Windows.Forms.Label lblStreetName;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblStreetNumber;
        private System.Windows.Forms.Label lblCity;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}