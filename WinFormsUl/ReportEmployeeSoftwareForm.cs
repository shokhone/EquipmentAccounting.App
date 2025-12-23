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
    public partial class ReportEmployeeSoftwareForm : Form
    {
        private readonly EquipmentService _service;
        private readonly EmployeeService _empService;
        public ReportEmployeeSoftwareForm(EquipmentService eqService, EmployeeService empService)
        {
            InitializeComponent();
            _service = eqService;
            _empService = empService;
            LoadEmployeesAsync();
            cmbEmployee.SelectedIndexChanged += async (s, e) => await LoadReportAsync();
        }

        private async Task LoadEmployeesAsync()
        {
            var employees = await _empService.GetAllAsync();
            cmbEmployee.DataSource = employees.ToList();
            cmbEmployee.DisplayMember = "FullName";
            cmbEmployee.ValueMember = "Id";
        }

        private async Task LoadReportAsync()
        {
            if (cmbEmployee.SelectedValue is int empId)
            {
                var softwares = await _service.GetSoftwareForEmployeeAsync(empId);
                dataGridView1.DataSource = softwares.Select(s => new
                {
                    ПО = s.Name,
                    Производитель = s.Manufacturer,
                    Ключ = s.LicenseKey,
                    Окончание = s.ExpiryDate
                }).ToList();
            }
        }
    }
}