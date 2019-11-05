namespace WinUI
{
    partial class MainInvoiceAddForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInvoice = new System.Windows.Forms.Label();
            this.cbxClientAddress = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxClient = new System.Windows.Forms.ComboBox();
            this.lblPartner = new System.Windows.Forms.Label();
            this.txtObservations = new System.Windows.Forms.TextBox();
            this.lblObservations = new System.Windows.Forms.Label();
            this.dateTimeInvoice = new System.Windows.Forms.DateTimePicker();
            this.txtNumberDocument = new System.Windows.Forms.TextBox();
            this.lblDataDocument = new System.Windows.Forms.Label();
            this.lblNumberDocument = new System.Windows.Forms.Label();
            this.btnClientSaveEdit = new System.Windows.Forms.Button();
            this.btnClientExitEdit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.lblInvoice);
            this.panel1.Controls.Add(this.cbxClientAddress);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbxClient);
            this.panel1.Controls.Add(this.lblPartner);
            this.panel1.Controls.Add(this.txtObservations);
            this.panel1.Controls.Add(this.lblObservations);
            this.panel1.Controls.Add(this.dateTimeInvoice);
            this.panel1.Controls.Add(this.txtNumberDocument);
            this.panel1.Controls.Add(this.lblDataDocument);
            this.panel1.Controls.Add(this.lblNumberDocument);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 239);
            this.panel1.TabIndex = 49;
            // 
            // lblInvoice
            // 
            this.lblInvoice.AutoSize = true;
            this.lblInvoice.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoice.Location = new System.Drawing.Point(175, 15);
            this.lblInvoice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblInvoice.Name = "lblInvoice";
            this.lblInvoice.Size = new System.Drawing.Size(242, 43);
            this.lblInvoice.TabIndex = 19;
            this.lblInvoice.Text = "Adauga facturi";
            // 
            // cbxClientAddress
            // 
            this.cbxClientAddress.DisplayMember = "StreetName";
            this.cbxClientAddress.FormattingEnabled = true;
            this.cbxClientAddress.Location = new System.Drawing.Point(160, 187);
            this.cbxClientAddress.Name = "cbxClientAddress";
            this.cbxClientAddress.Size = new System.Drawing.Size(121, 21);
            this.cbxClientAddress.TabIndex = 18;
            this.cbxClientAddress.ValueMember = "ClientAddressId";
            this.cbxClientAddress.SelectedIndexChanged += new System.EventHandler(this.CbxClientAddress_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Adresa partener:";
            // 
            // cbxClient
            // 
            this.cbxClient.DisplayMember = "ClientName";
            this.cbxClient.FormattingEnabled = true;
            this.cbxClient.Location = new System.Drawing.Point(160, 148);
            this.cbxClient.Name = "cbxClient";
            this.cbxClient.Size = new System.Drawing.Size(121, 21);
            this.cbxClient.TabIndex = 16;
            this.cbxClient.ValueMember = "ClientId";
            this.cbxClient.SelectedIndexChanged += new System.EventHandler(this.CbxClient_SelectedIndexChanged);
            // 
            // lblPartner
            // 
            this.lblPartner.AutoSize = true;
            this.lblPartner.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartner.Location = new System.Drawing.Point(79, 148);
            this.lblPartner.Name = "lblPartner";
            this.lblPartner.Size = new System.Drawing.Size(72, 19);
            this.lblPartner.TabIndex = 15;
            this.lblPartner.Text = "Partener:";
            // 
            // txtObservations
            // 
            this.txtObservations.Location = new System.Drawing.Point(385, 75);
            this.txtObservations.Multiline = true;
            this.txtObservations.Name = "txtObservations";
            this.txtObservations.Size = new System.Drawing.Size(325, 109);
            this.txtObservations.TabIndex = 12;
            // 
            // lblObservations
            // 
            this.lblObservations.AutoSize = true;
            this.lblObservations.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservations.Location = new System.Drawing.Point(292, 74);
            this.lblObservations.Name = "lblObservations";
            this.lblObservations.Size = new System.Drawing.Size(84, 19);
            this.lblObservations.TabIndex = 11;
            this.lblObservations.Text = "Observatii:";
            // 
            // dateTimeInvoice
            // 
            this.dateTimeInvoice.Location = new System.Drawing.Point(160, 112);
            this.dateTimeInvoice.Name = "dateTimeInvoice";
            this.dateTimeInvoice.Size = new System.Drawing.Size(121, 20);
            this.dateTimeInvoice.TabIndex = 10;
            // 
            // txtNumberDocument
            // 
            this.txtNumberDocument.Location = new System.Drawing.Point(160, 75);
            this.txtNumberDocument.Name = "txtNumberDocument";
            this.txtNumberDocument.Size = new System.Drawing.Size(121, 20);
            this.txtNumberDocument.TabIndex = 9;
            // 
            // lblDataDocument
            // 
            this.lblDataDocument.AutoSize = true;
            this.lblDataDocument.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDocument.Location = new System.Drawing.Point(39, 112);
            this.lblDataDocument.Name = "lblDataDocument";
            this.lblDataDocument.Size = new System.Drawing.Size(115, 19);
            this.lblDataDocument.TabIndex = 8;
            this.lblDataDocument.Text = "Data document:";
            // 
            // lblNumberDocument
            // 
            this.lblNumberDocument.AutoSize = true;
            this.lblNumberDocument.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberDocument.Location = new System.Drawing.Point(22, 76);
            this.lblNumberDocument.Name = "lblNumberDocument";
            this.lblNumberDocument.Size = new System.Drawing.Size(132, 19);
            this.lblNumberDocument.TabIndex = 7;
            this.lblNumberDocument.Text = "Numar Document:";
            // 
            // btnClientSaveEdit
            // 
            this.btnClientSaveEdit.BackColor = System.Drawing.Color.Green;
            this.btnClientSaveEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientSaveEdit.ForeColor = System.Drawing.Color.Transparent;
            this.btnClientSaveEdit.Location = new System.Drawing.Point(589, 270);
            this.btnClientSaveEdit.Name = "btnClientSaveEdit";
            this.btnClientSaveEdit.Size = new System.Drawing.Size(75, 34);
            this.btnClientSaveEdit.TabIndex = 46;
            this.btnClientSaveEdit.Text = "Save";
            this.btnClientSaveEdit.UseVisualStyleBackColor = false;
            this.btnClientSaveEdit.Click += new System.EventHandler(this.BtnClientSaveEdit_Click);
            // 
            // btnClientExitEdit
            // 
            this.btnClientExitEdit.BackColor = System.Drawing.Color.DarkRed;
            this.btnClientExitEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientExitEdit.ForeColor = System.Drawing.Color.Transparent;
            this.btnClientExitEdit.Location = new System.Drawing.Point(700, 270);
            this.btnClientExitEdit.Name = "btnClientExitEdit";
            this.btnClientExitEdit.Size = new System.Drawing.Size(75, 34);
            this.btnClientExitEdit.TabIndex = 47;
            this.btnClientExitEdit.Text = "Exit";
            this.btnClientExitEdit.UseVisualStyleBackColor = false;
            this.btnClientExitEdit.Click += new System.EventHandler(this.BtnClientExitEdit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 307);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(763, 166);
            this.dataGridView1.TabIndex = 50;
            // 
            // MainInvoiceAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 483);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClientSaveEdit);
            this.Controls.Add(this.btnClientExitEdit);
            this.Controls.Add(this.panel1);
            this.Name = "MainInvoiceAddForm";
            this.Text = "MainInvoiceAddForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtObservations;
        private System.Windows.Forms.Label lblObservations;
        private System.Windows.Forms.DateTimePicker dateTimeInvoice;
        private System.Windows.Forms.TextBox txtNumberDocument;
        private System.Windows.Forms.Label lblDataDocument;
        private System.Windows.Forms.Label lblNumberDocument;
        private System.Windows.Forms.ComboBox cbxClientAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxClient;
        private System.Windows.Forms.Label lblPartner;
        private System.Windows.Forms.Label lblInvoice;
        private System.Windows.Forms.Button btnClientSaveEdit;
        private System.Windows.Forms.Button btnClientExitEdit;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}