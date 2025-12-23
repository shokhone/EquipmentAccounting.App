namespace WinFormsUl
{
    partial class EquipmentTypeEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label lblName, lblManager;
        private TextBox txtName, txtManager;
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
            this.lblManager = new Label();
            this.txtManager = new TextBox();
            this.btnSave = new Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new Point(12, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new Size(46, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Название:";
            // 
            // txtName
            // 
            this.txtName.Location = new Point(12, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new Size(260, 22);
            this.txtName.TabIndex = 1;
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            this.lblManager.Location = new Point(12, 62);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new Size(83, 16);
            this.lblManager.TabIndex = 2;
            this.lblManager.Text = "Руководитель:";
            // 
            // txtManager
            // 
            this.txtManager.Location = new Point(12, 81);
            this.txtManager.Name = "txtManager";
            this.txtManager.Size = new Size(260, 22);
            this.txtManager.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new Point(12, 109);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new Size(260, 30);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // DepartmentEditForm
            // 
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(284, 151);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtManager);
            this.Controls.Add(this.lblManager);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DepartmentEditForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Подразделение";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}