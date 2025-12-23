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
    public partial class EquipmentForm : Form
    {
        private readonly EquipmentService _service;
        private readonly EquipmentTypeService _typeService;
        private readonly EmployeeService _empService;
        public EquipmentForm(EquipmentService service, EquipmentTypeService typeService, EmployeeService empService)
        {
            InitializeComponent();
            _service = service;
            _typeService = typeService;
            _empService = empService;
            LoadDataAsync();
            btnAdd.Click += async (s, e) => await ShowEditForm(null);
            btnEdit.Click += async (s, e) =>
            {
                if (dataGridView1.CurrentRow?.DataBoundItem is Equipment eq)
                    await ShowEditForm(eq);
            };
            btnDelete.Click += async (s, e) =>
            {
                if (dataGridView1.CurrentRow?.DataBoundItem is Equipment eq &&
                    MessageBox.Show("Удалить?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    await _service.DeleteAsync(eq.Id);
                    LoadDataAsync();
                }
            };
            btnMove.Click += async (s, e) =>
            {
                if (dataGridView1.CurrentRow?.DataBoundItem is Equipment eq)
                {
                    using var moveForm = new MoveEquipmentForm(_service, _empService, eq.Id);
                    if (moveForm.ShowDialog() == DialogResult.OK)
                        LoadDataAsync();
                }
            };
        }

        private async Task LoadDataAsync()
        {
            var equipments = await _service.GetAllAsync();
            dataGridView1.DataSource = equipments.ToList();
        }

        private async Task ShowEditForm(Equipment? eq)
        {
            using var editForm = new EquipmentEditForm(_service, _typeService, _empService, eq);
            if (editForm.ShowDialog() == DialogResult.OK)
                await LoadDataAsync();
        }
    }
}
