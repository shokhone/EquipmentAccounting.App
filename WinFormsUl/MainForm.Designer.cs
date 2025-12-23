namespace WinFormsUl
{
    partial class MainForm
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подразделенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типыОборудованияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учетОборудованияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оборудованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.историяПеремещенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учетПОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лицензииПОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.установленноеПОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оборудованиеПоПодразделениямToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пОНаКомпьютереСотрудникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.treeViewNavigation = new System.Windows.Forms.TreeView();
            this.menuStripMain.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.panelNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.учетОборудованияToolStripMenuItem,
            this.учетПОToolStripMenuItem,
            this.отчетыToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(1200, 28);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подразделенияToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.типыОборудованияToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // подразделенияToolStripMenuItem
            // 
            this.подразделенияToolStripMenuItem.Name = "подразделенияToolStripMenuItem";
            this.подразделенияToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.подразделенияToolStripMenuItem.Text = "Подразделения";
            this.подразделенияToolStripMenuItem.Click += new System.EventHandler(this.подразделенияToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // типыОборудованияToolStripMenuItem
            // 
            this.типыОборудованияToolStripMenuItem.Name = "типыОборудованияToolStripMenuItem";
            this.типыОборудованияToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.типыОборудованияToolStripMenuItem.Text = "Типы оборудования";
            this.типыОборудованияToolStripMenuItem.Click += new System.EventHandler(this.типыОборудованияToolStripMenuItem_Click);
            // 
            // учетОборудованияToolStripMenuItem
            // 
            this.учетОборудованияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оборудованиеToolStripMenuItem,
            this.историяПеремещенийToolStripMenuItem});
            this.учетОборудованияToolStripMenuItem.Name = "учетОборудованияToolStripMenuItem";
            this.учетОборудованияToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.учетОборудованияToolStripMenuItem.Text = "Учет оборудования";
            // 
            // оборудованиеToolStripMenuItem
            // 
            this.оборудованиеToolStripMenuItem.Name = "оборудованиеToolStripMenuItem";
            this.оборудованиеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.оборудованиеToolStripMenuItem.Text = "Оборудование";
            this.оборудованиеToolStripMenuItem.Click += new System.EventHandler(this.оборудованиеToolStripMenuItem_Click);
            // 
            // историяПеремещенийToolStripMenuItem
            // 
            this.историяПеремещенийToolStripMenuItem.Name = "историяПеремещенийToolStripMenuItem";
            this.историяПеремещенийToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.историяПеремещенийToolStripMenuItem.Text = "История перемещений";
            this.историяПеремещенийToolStripMenuItem.Click += new System.EventHandler(this.историяПеремещенийToolStripMenuItem_Click);
            // 
            // учетПОToolStripMenuItem
            // 
            this.учетПОToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.лицензииПОToolStripMenuItem,
            this.установленноеПОToolStripMenuItem});
            this.учетПОToolStripMenuItem.Name = "учетПОToolStripMenuItem";
            this.учетПОToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.учетПОToolStripMenuItem.Text = "Учет ПО";
            // 
            // лицензииПОToolStripMenuItem
            // 
            this.лицензииПОToolStripMenuItem.Name = "лицензииПОToolStripMenuItem";
            this.лицензииПОToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.лицензииПОToolStripMenuItem.Text = "Лицензии ПО";
            this.лицензииПОToolStripMenuItem.Click += new System.EventHandler(this.лицензииПОToolStripMenuItem_Click);
            // 
            // установленноеПОToolStripMenuItem
            // 
            this.установленноеПОToolStripMenuItem.Name = "установленноеПОToolStripMenuItem";
            this.установленноеПОToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.установленноеПОToolStripMenuItem.Text = "Установленное ПО";
            this.установленноеПОToolStripMenuItem.Click += new System.EventHandler(this.установленноеПОToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оборудованиеПоПодразделениямToolStripMenuItem,
            this.пОНаКомпьютереСотрудникаToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // оборудованиеПоПодразделениямToolStripMenuItem
            // 
            this.оборудованиеПоПодразделениямToolStripMenuItem.Name = "оборудованиеПоПодразделениямToolStripMenuItem";
            this.оборудованиеПоПодразделениямToolStripMenuItem.Size = new System.Drawing.Size(349, 26);
            this.оборудованиеПоПодразделениямToolStripMenuItem.Text = "Оборудование по подразделениям";
            this.оборудованиеПоПодразделениямToolStripMenuItem.Click += new System.EventHandler(this.оборудованиеПоПодразделениямToolStripMenuItem_Click);
            // 
            // пОНаКомпьютереСотрудникаToolStripMenuItem
            // 
            this.пОНаКомпьютереСотрудникаToolStripMenuItem.Name = "пОНаКомпьютереСотрудникаToolStripMenuItem";
            this.пОНаКомпьютереСотрудникаToolStripMenuItem.Size = new System.Drawing.Size(349, 26);
            this.пОНаКомпьютереСотрудникаToolStripMenuItem.Text = "ПО на компьютере сотрудника";
            this.пОНаКомпьютереСотрудникаToolStripMenuItem.Click += new System.EventHandler(this.пОНаКомпьютереСотрудникаToolStripMenuItem_Click);
            // 
            // toolStripMain
            // 
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAdd,
            this.toolStripButtonEdit,
            this.toolStripButtonDelete,
            this.toolStripSeparator1,
            this.toolStripButtonRefresh});
            this.toolStripMain.Location = new System.Drawing.Point(0, 28);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1200, 27);
            this.toolStripMain.TabIndex = 1;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
           
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonAdd.Text = "Добавить";
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
           
            this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonEdit.Text = "Изменить";
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
           
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonDelete.Text = "Удалить";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonRefresh.Text = "Обновить";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
            // 
            // statusStripMain
            // 
            this.statusStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStripMain.Location = new System.Drawing.Point(0, 678);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStripMain.Size = new System.Drawing.Size(1200, 22);
            this.statusStripMain.SizingGrip = false;
            this.statusStripMain.TabIndex = 2;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel.Text = "Готов к работе...";
            // 
            // panelNavigation
            // 
            this.panelNavigation.Controls.Add(this.treeViewNavigation);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavigation.Location = new System.Drawing.Point(0, 55);
            this.panelNavigation.Margin = new System.Windows.Forms.Padding(4);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(250, 623);
            this.panelNavigation.TabIndex = 3;
            // 
            // treeViewNavigation
            // 
            this.treeViewNavigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewNavigation.Location = new System.Drawing.Point(0, 0);
            this.treeViewNavigation.Margin = new System.Windows.Forms.Padding(4);
            this.treeViewNavigation.Name = "treeViewNavigation";
            this.treeViewNavigation.Size = new System.Drawing.Size(250, 623);
            this.treeViewNavigation.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.menuStripMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет оборудования";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.panelNavigation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.TreeView treeViewNavigation;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подразделенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типыОборудованияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem учетОборудованияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оборудованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem историяПеремещенийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem учетПОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лицензииПОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem установленноеПОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оборудованиеПоПодразделениямToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пОНаКомпьютереСотрудникаToolStripMenuItem;
    }
}