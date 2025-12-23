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
using DAL.Models;
using License = DAL.Models.License;

namespace WinFormsUl
{
    public partial class LicenseForm : Form
    {
        private readonly LicenseService _service;
        public LicenseForm(LicenseService service)
        {
            InitializeComponent();
            _service = service;
            LoadDataAsync();
            btnAdd.Click += async (s, e) => await ShowEditForm(null);
            btnEdit.Click += async (s, e) =>
            {
                if (dataGridView1.CurrentRow?.DataBoundItem is License license)
                    await ShowEditForm(license);
            };
            btnDelete.Click += async (s, e) =>
            {
                if (dataGridView1.CurrentRow?.DataBoundItem is License license &&
                    MessageBox.Show("Удалить лицензию?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    await _service.DeleteAsync(license.Id);
                    LoadDataAsync();
                }
            };
        }

        private async Task LoadDataAsync()
        {
            try
            {
                var licenses = await _service.GetAllAsync();
                dataGridView1.DataSource = licenses.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task ShowEditForm(DAL.Models.License? license)
        {
            using var editForm = new LicenseEditForm(_service, license);
            if (editForm.ShowDialog() == DialogResult.OK)
                await LoadDataAsync();
        }
    }
}