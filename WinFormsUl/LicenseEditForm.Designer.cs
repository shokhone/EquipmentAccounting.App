namespace WinFormsUl
{
    partial class LicenseEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label lblName, lblManufacturer, lblKey, lblExpiryDate;
        private TextBox txtName, txtManufacturer, txtKey;
        private DateTimePicker dtpExpiryDate;
        private Button btnSave;
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
            this.lblName = new Label();
            this.txtName = new TextBox();
            this.lblManufacturer = new Label();
            this.txtManufacturer = new TextBox();
            this.lblKey = new Label();
            this.txtKey = new TextBox();
            this.lblExpiryDate = new Label();
            this.dtpExpiryDate = new DateTimePicker();
            this.btnSave = new Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new Point(12, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new Size(69, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Название ПО:";
            // 
            // txtName
            // 
            this.txtName.Location = new Point(12, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new Size(260, 22);
            this.txtName.TabIndex = 1;
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new Point(12, 62);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new Size(86, 16);
            this.lblManufacturer.TabIndex = 2;
            this.lblManufacturer.Text = "Производитель:";
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new Point(12, 81);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new Size(260, 22);
            this.txtManufacturer.TabIndex = 3;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new Point(12, 109);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new Size(84, 16);
            this.lblKey.TabIndex = 4;
            this.lblKey.Text = "Ключ лицензии:";
            // 
            // txtKey
            // 
            this.txtKey.Location = new Point(12, 128);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new Size(260, 22);
            this.txtKey.TabIndex = 5;
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Location = new Point(12, 156);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new Size(109, 16);
            this.lblExpiryDate.TabIndex = 6;
            this.lblExpiryDate.Text = "Дата окончания:";
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.Format = DateTimePickerFormat.Short;
            this.dtpExpiryDate.Location = new Point(12, 175);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new Size(260, 22);
            this.dtpExpiryDate.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new Point(12, 203);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new Size(260, 30);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // LicenseEditForm
            // 
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(284, 245);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpExpiryDate);
            this.Controls.Add(this.lblExpiryDate);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LicenseEditForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Лицензия ПО";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}