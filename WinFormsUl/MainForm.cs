using BLL.Services;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUl
{
    public partial class MainForm : Form
    {
        private readonly DepartmentService _deptService;
        private readonly EmployeeService _empService;
        private readonly EquipmentTypeService _typeService;
        private readonly EquipmentService _eqService;
        private readonly LicenseService _licService;
        public MainForm()
        {
            InitializeComponent();
            var context = new EquipmentDbContext();
            _deptService = new DepartmentService(context);
            _empService = new EmployeeService(context);
            _typeService = new EquipmentTypeService(context);
            _eqService = new EquipmentService(context);
            _licService = new LicenseService(context);

            // TreeView навигация (как ранее)
            var sprefNode = treeViewNavigation.Nodes.Add("Справочники");
            sprefNode.Nodes.Add("Подразделения").Tag = "Departments";
            sprefNode.Nodes.Add("Сотрудники").Tag = "Employees";
            sprefNode.Nodes.Add("Типы оборудования").Tag = "EquipmentTypes";

            var equipNode = treeViewNavigation.Nodes.Add("Учет оборудования");
            equipNode.Nodes.Add("Оборудование").Tag = "Equipment";
            equipNode.Nodes.Add("История перемещений").Tag = "EquipmentHistory";

            var softNode = treeViewNavigation.Nodes.Add("Учет ПО");
            softNode.Nodes.Add("Лицензии ПО").Tag = "Licenses";
            softNode.Nodes.Add("Установленное ПО").Tag = "InstalledSoftware";

            var reportNode = treeViewNavigation.Nodes.Add("Отчеты");
            reportNode.Nodes.Add("Оборудование по подразделениям").Tag = "ReportDeptEquipment";
            reportNode.Nodes.Add("ПО на компьютере сотрудника").Tag = "ReportEmployeeSoftware";

            treeViewNavigation.AfterSelect += TreeViewNavigation_AfterSelect;
        }

        private void TreeViewNavigation_AfterSelect(object? sender, TreeViewEventArgs e)
        {
            try
            {
                var tag = e.Node.Tag?.ToString();
                Form? form = tag switch
                {
                    "Departments" => new DepartmentForm(_deptService) { MdiParent = this },
                    "Employees" => new EmployeeForm(_empService, _deptService) { MdiParent = this },
                    "EquipmentTypes" => new EquipmentTypeForm(_typeService) { MdiParent = this },
                    "Equipment" => new EquipmentForm(_eqService, _typeService, _empService) { MdiParent = this },
                    "EquipmentHistory" => new EquipmentHistoryForm(_eqService) { MdiParent = this },
                    "Licenses" => new LicenseForm(_licService) { MdiParent = this },
                    "InstalledSoftware" => new InstalledSoftwareForm(_eqService, _licService) { MdiParent = this },
                    "ReportDeptEquipment" => new ReportDepartmentEquipmentForm(_eqService, _deptService) { MdiParent = this },
                    "ReportEmployeeSoftware" => new ReportEmployeeSoftwareForm(_eqService, _empService) { MdiParent = this },
                    _ => null
                };
                if (form != null)
                {
                    form.WindowState = FormWindowState.Maximized;
                    form.Show();
                    toolStripStatusLabel.Text = $"Открыто: {e.Node.Text}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        private void подразделенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new DepartmentForm(_deptService) { MdiParent = this };
            form.Show();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new EmployeeForm(_empService, _deptService) { MdiParent = this };
            form.Show();
        }

        private void типыОборудованияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new EquipmentTypeForm(_typeService) { MdiParent = this };
            form.Show();
        }

        private void оборудованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new EquipmentForm(_eqService, _typeService, _empService) { MdiParent = this };
            form.Show();
        }

        private void историяПеремещенийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new EquipmentHistoryForm(_eqService) { MdiParent = this };
            form.Show();
        }

        private void лицензииПОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new LicenseForm(_licService) { MdiParent = this };
            form.Show();
        }

        private void установленноеПОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new InstalledSoftwareForm(_eqService, _licService) { MdiParent = this };
            form.Show();
        }

        private void оборудованиеПоПодразделениямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ReportDepartmentEquipmentForm(_eqService, _deptService) { MdiParent = this };
            form.Show();
        }

        private void пОНаКомпьютереСотрудникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ReportEmployeeSoftwareForm(_eqService, _empService) { MdiParent = this };
            form.Show();
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Обновлено";
        }
    }
}