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
    public partial class EmployeeForm : Form
    {
        private readonly EmployeeService _service;
        private readonly DepartmentService _deptService;
        public EmployeeForm(EmployeeService service, DepartmentService deptService)
        {
            InitializeComponent();
            _service = service;
            _deptService = deptService;
            LoadDataAsync();
            btnAdd.Click += async (s, e) => await ShowEditForm(null);
            btnEdit.Click += async (s, e) =>
            {
                if (dataGridView1.CurrentRow?.DataBoundItem is Employee emp)
                    await ShowEditForm(emp);
            };
            btnDelete.Click += async (s, e) =>
            {
                if (dataGridView1.CurrentRow?.DataBoundItem is Employee emp &&
                    MessageBox.Show("Удалить?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    await _service.DeleteAsync(emp.Id);
                    LoadDataAsync();
                }
            };
        }

        private async Task LoadDataAsync()
        {
            var employees = await _service.GetAllAsync();
            dataGridView1.DataSource = employees.ToList();
        }

        private async Task ShowEditForm(Employee? emp)
        {
            using var editForm = new EmployeeEditForm(_service, _deptService, emp);
            if (editForm.ShowDialog() == DialogResult.OK)
                await LoadDataAsync();
        }
    }
}