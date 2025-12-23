namespace WinFormsUl
{
    partial class EmployeeEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label lblFullName, lblPosition, lblDepartment;
        private TextBox txtFullName, txtPosition;
        private ComboBox cmbDepartment;
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
            this.lblFullName = new Label { Text = "ФИО:", Location = new Point(12, 15), AutoSize = true };
            this.txtFullName = new TextBox { Location = new Point(12, 34), Size = new Size(260, 22) };
            this.lblPosition = new Label { Text = "Должность:", Location = new Point(12, 62), AutoSize = true };
            this.txtPosition = new TextBox { Location = new Point(12, 81), Size = new Size(260, 22) };
            this.lblDepartment = new Label { Text = "Подразделение:", Location = new Point(12, 109), AutoSize = true };
            this.cmbDepartment = new ComboBox { Location = new Point(12, 128), Size = new Size(260, 23), DropDownStyle = ComboBoxStyle.DropDownList };
            this.btnSave = new Button { Text = "Сохранить", Location = new Point(12, 157), Size = new Size(260, 30) };

            this.ClientSize = new Size(284, 200);
            this.Controls.AddRange(new Control[] { lblFullName, txtFullName, lblPosition, txtPosition, lblDepartment, cmbDepartment, btnSave });
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Сотрудник";
        }

        #endregion
    }
}