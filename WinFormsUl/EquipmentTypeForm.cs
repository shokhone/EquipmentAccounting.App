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
    public partial class EquipmentTypeForm : Form
    {
        private readonly EquipmentTypeService _service;
        public EquipmentTypeForm(EquipmentTypeService service)
        {
            InitializeComponent();
            _service = service;
            LoadDataAsync();
            btnAdd.Click += async (s, e) => await ShowEditForm(null);
            btnEdit.Click += async (s, e) =>
            {
                if (dataGridView1.CurrentRow?.DataBoundItem is EquipmentType type)
                    await ShowEditForm(type);
            };
            btnDelete.Click += async (s, e) =>
            {
                if (dataGridView1.CurrentRow?.DataBoundItem is EquipmentType type &&
                    MessageBox.Show("Удалить?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    await _service.DeleteAsync(type.Id);
                    LoadDataAsync();
                }
            };
        }

        private async Task LoadDataAsync()
        {
            var types = await _service.GetAllAsync();
            dataGridView1.DataSource = types.ToList();
        }

        private async Task ShowEditForm(EquipmentType? type)
        {
            using var editForm = new EquipmentTypeEditForm(_service, type);
            if (editForm.ShowDialog() == DialogResult.OK)
                await LoadDataAsync();
        }
    }
}
