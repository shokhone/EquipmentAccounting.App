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
    public partial class ReportDepartmentEquipmentForm : Form
    {
        private readonly EquipmentService _service;
        private readonly DepartmentService _deptService;
        public ReportDepartmentEquipmentForm(EquipmentService eqService, DepartmentService deptService)
        {
            InitializeComponent();
            _service = eqService;
            _deptService = deptService;
            LoadDepartmentsAsync();
            cmbDepartment.SelectedIndexChanged += async (s, e) => await LoadReportAsync();
        }

        private async Task LoadDepartmentsAsync()
        {
            var depts = await _deptService.GetAllAsync();
            cmbDepartment.DataSource = depts.ToList();
            cmbDepartment.DisplayMember = "Name";
            cmbDepartment.ValueMember = "Id";
        }

        private async Task LoadReportAsync()
        {
            if (cmbDepartment.SelectedValue is int deptId)
            {
                var equipments = await _service.GetByDepartmentAsync(deptId);
                dataGridView1.DataSource = equipments.Select(e => new
                {
                    Название = e.Name,
                    Инвентарный = e.InventoryNumber,
                    Тип = e.Type.Name,
                    Сотрудник = e.ResponsibleEmployee?.FullName ?? "Нет"
                }).ToList();
            }
        }
    }
}