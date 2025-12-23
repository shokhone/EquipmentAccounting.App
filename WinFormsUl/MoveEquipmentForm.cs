using BLL.Services;
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
    public partial class MoveEquipmentForm : Form
    {
        private readonly EquipmentService _service;
        private readonly EmployeeService _empService;
        private readonly int _equipmentId;
        public MoveEquipmentForm(EquipmentService service, EmployeeService empService, int equipmentId)
        {
            InitializeComponent();
            _service = service;
            _empService = empService;
            _equipmentId = equipmentId;
            LoadEmployeesAsync();
            btnAssign.Click += async (s, e) => await AssignAsync();
        }

        private async Task LoadEmployeesAsync()
        {
            var employees = await _empService.GetAllAsync();
            cmbNewEmployee.DataSource = employees.ToList();
            cmbNewEmployee.DisplayMember = "FullName";
            cmbNewEmployee.ValueMember = "Id";
            cmbNewEmployee.Items.Insert(0, "Без ответственного");
        }

        private async Task AssignAsync()
        {
            int? newEmpId = cmbNewEmployee.SelectedIndex == 0 ? null : (int?)cmbNewEmployee.SelectedValue;
            await _service.AssignToEmployeeAsync(_equipmentId, newEmpId);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}