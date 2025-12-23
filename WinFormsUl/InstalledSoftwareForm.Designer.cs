namespace WinFormsUl
{
    partial class InstalledSoftwareForm
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
            this.lblEquipment = new System.Windows.Forms.Label();
            this.cmbEquipment = new System.Windows.Forms.ComboBox();
            this.lblLicense = new System.Windows.Forms.Label();
            this.cmbLicense = new System.Windows.Forms.ComboBox();
            this.lblInstallDate = new System.Windows.Forms.Label();
            this.dtpInstall = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.listBoxInstalled = new System.Windows.Forms.ListBox();
            this.lblInstalled = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEquipment
            // 
            this.lblEquipment.AutoSize = true;
            this.lblEquipment.Location = new System.Drawing.Point(12, 15);
            this.lblEquipment.Name = "lblEquipment";
            this.lblEquipment.Size = new System.Drawing.Size(82, 15);
            this.lblEquipment.TabIndex = 0;
            this.lblEquipment.Text = "Оборудование:";
            // 
            // cmbEquipment
            // 
            this.cmbEquipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEquipment.FormattingEnabled = true;
            this.cmbEquipment.Location = new System.Drawing.Point(100, 12);
            this.cmbEquipment.Name = "cmbEquipment";
            this.cmbEquipment.Size = new System.Drawing.Size(250, 23);
            this.cmbEquipment.TabIndex = 1;
            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.Location = new System.Drawing.Point(12, 45);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(64, 15);
            this.lblLicense.TabIndex = 2;
            this.lblLicense.Text = "Лицензия:";
            // 
            // cmbLicense
            // 
            this.cmbLicense.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLicense.FormattingEnabled = true;
            this.cmbLicense.Location = new System.Drawing.Point(100, 42);
            this.cmbLicense.Name = "cmbLicense";
            this.cmbLicense.Size = new System.Drawing.Size(250, 23);
            this.cmbLicense.TabIndex = 3;
            // 
            // lblInstallDate
            // 
            this.lblInstallDate.AutoSize = true;
            this.lblInstallDate.Location = new System.Drawing.Point(12, 75);
            this.lblInstallDate.Name = "lblInstallDate";
            this.lblInstallDate.Size = new System.Drawing.Size(83, 15);
            this.lblInstallDate.TabIndex = 4;
            this.lblInstallDate.Text = "Дата установки:";
            // 
            // dtpInstall
            // 
            this.dtpInstall.Location = new System.Drawing.Point(100, 72);
            this.dtpInstall.Name = "dtpInstall";
            this.dtpInstall.Size = new System.Drawing.Size(250, 23);
            this.dtpInstall.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(100, 105);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 25);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Установить";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(240, 105);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(110, 25);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // listBoxInstalled
            // 
            this.listBoxInstalled.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxInstalled.FormattingEnabled = true;
            this.listBoxInstalled.ItemHeight = 15;
            this.listBoxInstalled.Location = new System.Drawing.Point(12, 140);
            this.listBoxInstalled.Name = "listBoxInstalled";
            this.listBoxInstalled.Size = new System.Drawing.Size(338, 199);
            this.listBoxInstalled.TabIndex = 8;
            // 
            // lblInstalled
            // 
            this.lblInstalled.AutoSize = true;
            this.lblInstalled.Location = new System.Drawing.Point(12, 122);
            this.lblInstalled.Name = "lblInstalled";
            this.lblInstalled.Size = new System.Drawing.Size(127, 15);
            this.lblInstalled.TabIndex = 9;
            this.lblInstalled.Text = "Установленное ПО:";
            // 
            // InstalledSoftwareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 350);
            this.Controls.Add(this.lblInstalled);
            this.Controls.Add(this.listBoxInstalled);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpInstall);
            this.Controls.Add(this.lblInstallDate);
            this.Controls.Add(this.cmbLicense);
            this.Controls.Add(this.lblLicense);
            this.Controls.Add(this.cmbEquipment);
            this.Controls.Add(this.lblEquipment);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "InstalledSoftwareForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Установленное ПО";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEquipment;
        private System.Windows.Forms.ComboBox cmbEquipment;
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.ComboBox cmbLicense;
        private System.Windows.Forms.Label lblInstallDate;
        private System.Windows.Forms.DateTimePicker dtpInstall;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox listBoxInstalled;
        private System.Windows.Forms.Label lblInstalled;
    }
}