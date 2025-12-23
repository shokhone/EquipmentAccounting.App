namespace WinFormsUl
{
    partial class EquipmentEditForm
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblInventory = new System.Windows.Forms.Label();
            this.txtInventory = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSerial = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.lblDateAdded = new System.Windows.Forms.Label();
            this.dtpDateAdded = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.panelButtons = new System.Windows.Forms.Panel();  // Панель для кнопок
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();  // Новая кнопка Отмена
            this.tableLayoutPanel.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel (поля формы)
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.lblInventory, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.txtInventory, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.lblName, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.txtName, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.lblSerial, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.txtSerial, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.lblType, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.cmbType, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.lblEmployee, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.cmbEmployee, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.lblDateAdded, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.dtpDateAdded, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.lblStatus, 0, 6);
            this.tableLayoutPanel.Controls.Add(this.cmbStatus, 1, 6);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 7;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(400, 210);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // lblInventory
            // 
            this.lblInventory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblInventory.AutoSize = true;
            this.lblInventory.Location = new System.Drawing.Point(3, 8);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(120, 16);
            this.lblInventory.TabIndex = 0;
            this.lblInventory.Text = "Инвентарный номер:";
            // 
            // txtInventory
            // 
            this.txtInventory.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtInventory.Location = new System.Drawing.Point(146, 4);
            this.txtInventory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.Size = new System.Drawing.Size(251, 22);
            this.txtInventory.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 16);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Название:";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtName.Location = new System.Drawing.Point(146, 34);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(251, 22);
            this.txtName.TabIndex = 3;
            // 
            // lblSerial
            // 
            this.lblSerial.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSerial.AutoSize = true;
            this.lblSerial.Location = new System.Drawing.Point(3, 68);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(94, 16);
            this.lblSerial.TabIndex = 4;
            this.lblSerial.Text = "Серийный номер:";
            // 
            // txtSerial
            // 
            this.txtSerial.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtSerial.Location = new System.Drawing.Point(146, 64);
            this.txtSerial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(251, 22);
            this.txtSerial.TabIndex = 5;
            // 
            // lblType
            // 
            this.lblType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(3, 98);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(33, 16);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "Тип:";
            // 
            // cmbType
            // 
            this.cmbType.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(146, 94);
            this.cmbType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(251, 24);
            this.cmbType.TabIndex = 7;
            // 
            // lblEmployee
            // 
            this.lblEmployee.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(3, 128);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(170, 16);
            this.lblEmployee.TabIndex = 8;
            this.lblEmployee.Text = "Ответственный сотрудник:";
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(146, 124);
            this.cmbEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(251, 24);
            this.cmbEmployee.TabIndex = 9;
            // 
            // lblDateAdded
            // 
            this.lblDateAdded.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDateAdded.AutoSize = true;
            this.lblDateAdded.Location = new System.Drawing.Point(3, 158);
            this.lblDateAdded.Name = "lblDateAdded";
            this.lblDateAdded.Size = new System.Drawing.Size(190, 16);
            this.lblDateAdded.TabIndex = 10;
            this.lblDateAdded.Text = "Дата постановки на учет:";
            // 
            // dtpDateAdded
            // 
            this.dtpDateAdded.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dtpDateAdded.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateAdded.Location = new System.Drawing.Point(146, 154);
            this.dtpDateAdded.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDateAdded.Name = "dtpDateAdded";
            this.dtpDateAdded.Size = new System.Drawing.Size(251, 22);
            this.dtpDateAdded.TabIndex = 11;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(3, 188);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 16);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Статус:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(146, 184);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(251, 24);
            this.cmbStatus.TabIndex = 13;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnCancel);
            this.panelButtons.Controls.Add(this.btnSave);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 210);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(400, 50);
            this.panelButtons.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(230, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(316, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // EquipmentEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 260);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.panelButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EquipmentEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Оборудование";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.TextBox txtInventory;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Label lblDateAdded;
        private System.Windows.Forms.DateTimePicker dtpDateAdded;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}