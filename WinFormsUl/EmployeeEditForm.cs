using BLL.Services;
using DAL.Models;
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
    public partial class EmployeeEditForm : Form
    {
        private readonly EmployeeService _service;
        private readonly DepartmentService _deptService;
        private Employee? _employee;
        public EmployeeEditForm(EmployeeService service, DepartmentService deptService, Employee? employee = null)
        {
            InitializeComponent();
            _service = service;
            _deptService = deptService;
            _employee = employee;
            LoadDepartmentsAsync();
            if (_employee != null)
            {
                txtFullName.Text = _employee.FullName;
                txtPosition.Text = _employee.Position;
                cmbDepartment.SelectedValue = _employee.DepartmentId;
                Text = "Редактировать сотрудника";
            }
            else
            {
                Text = "Добавить сотрудника";
            }
            btnSave.Click += async (s, e) => await SaveAsync();
        }

        private async Task LoadDepartmentsAsync()
        {
            var departments = await _deptService.GetAllAsync();
            cmbDepartment.DataSource = departments.ToList();
            cmbDepartment.DisplayMember = "Name";
            cmbDepartment.ValueMember = "Id";
        }

        private async Task SaveAsync()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("ФИО обязательно!", "Ошибка");
                return;
            }

            var emp = _employee ?? new Employee();
            emp.FullName = txtFullName.Text;
            emp.Position = txtPosition.Text;
            emp.DepartmentId = (int)cmbDepartment.SelectedValue;

            try
            {
                if (_employee != null)
                    await _service.UpdateAsync(emp);
                else
                    await _service.AddAsync(emp);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Close();
        }
    }
}
