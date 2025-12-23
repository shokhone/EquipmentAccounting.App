using BLL.Services;
using System;
using DAL.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using License = DAL.Models.License;

namespace WinFormsUl
{
    public partial class LicenseEditForm : Form
    {
        private readonly LicenseService _service;
        private License? _license;
        public LicenseEditForm(LicenseService service, License? license = null)
        {
            InitializeComponent();
      _service = service;
            _license = license;
            if (_license != null)
            {
                txtName.Text = _license.Name;
                txtManufacturer.Text = _license.Manufacturer;
                txtKey.Text = _license.LicenseKey;
                dtpExpiryDate.Value = _license.ExpiryDate;
                Text = "Редактировать лицензию";
            }
            else
            {
                Text = "Добавить лицензию";
                dtpExpiryDate.Value = DateTime.Now.AddYears(1); // По умолчанию +1 год
            }
            btnSave.Click += async (s, e) => await SaveAsync();
        }

        private async Task SaveAsync()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Название ПО обязательно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var lic = _license ?? new License();
            lic.Name = txtName.Text;
            lic.Manufacturer = txtManufacturer.Text;
            lic.LicenseKey = txtKey.Text;
            lic.ExpiryDate = dtpExpiryDate.Value;

            try
            {
                if (_license != null)
                    await _service.UpdateAsync(lic);
                else
                    await _service.AddAsync(lic);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Close();
        }
    }
}