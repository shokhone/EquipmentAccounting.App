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
    public partial class DepartmentForm : Form
    {
        private readonly DepartmentService _service;
        private DepartmentService? service;

        public DepartmentForm(DepartmentService deptService)
        {
            InitializeComponent();
            _service = service;
            LoadDataAsync();
            btnAdd.Click += async (s, e) => await ShowEditForm(null);
            btnEdit.Click += async (s, e) =>
            {
                if (dataGridView1.CurrentRow?.DataBoundItem is Department dept)
                    await ShowEditForm(dept);
            };
            btnDelete.Click += async (s, e) =>
            {
                if (dataGridView1.CurrentRow?.DataBoundItem is Department dept &&
                    MessageBox.Show("Удалить?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    await _service.DeleteAsync(dept.Id);
                    LoadDataAsync();
                }
            };
        }

        private async Task LoadDataAsync()
        {
            var departments = await _service.GetAllAsync();
            dataGridView1.DataSource = departments.ToList();
        }

        private async Task ShowEditForm(Department? dept)
        {
            using var editForm = new DepartmentEditForm(_service, dept);
            if (editForm.ShowDialog() == DialogResult.OK)
                await LoadDataAsync();
        }
    }
}
