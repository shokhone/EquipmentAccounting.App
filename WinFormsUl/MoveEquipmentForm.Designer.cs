namespace WinFormsUl
{
    partial class MoveEquipmentForm
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
            this.lblNewEmployee = new System.Windows.Forms.Label();
            this.cmbNewEmployee = new System.Windows.Forms.ComboBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNewEmployee
            // 
            this.lblNewEmployee.AutoSize = true;
            this.lblNewEmployee.Location = new System.Drawing.Point(12, 20);
            this.lblNewEmployee.Name = "lblNewEmployee";
            this.lblNewEmployee.Size = new System.Drawing.Size(115, 15);
            this.lblNewEmployee.TabIndex = 0;
            this.lblNewEmployee.Text = "Новый сотрудник:";
            // 
            // cmbNewEmployee
            // 
            this.cmbNewEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNewEmployee.FormattingEnabled = true;
            this.cmbNewEmployee.Location = new System.Drawing.Point(12, 40);
            this.cmbNewEmployee.Name = "cmbNewEmployee";
            this.cmbNewEmployee.Size = new System.Drawing.Size(276, 23);
            this.cmbNewEmployee.TabIndex = 1;
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(12, 80);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(276, 25);
            this.btnAssign.TabIndex = 2;
            this.btnAssign.Text = "Назначить";
            this.btnAssign.UseVisualStyleBackColor = true;
            // 
            // MoveEquipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.cmbNewEmployee);
            this.Controls.Add(this.lblNewEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MoveEquipmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Переместить оборудование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewEmployee;
        private System.Windows.Forms.ComboBox cmbNewEmployee;
        private System.Windows.Forms.Button btnAssign;
    }
}