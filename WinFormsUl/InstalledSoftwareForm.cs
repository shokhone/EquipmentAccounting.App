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
    public partial class InstalledSoftwareForm : Form
    {
        private readonly EquipmentService _service;
        private readonly LicenseService _licService;
        public InstalledSoftwareForm(EquipmentService service, LicenseService licService)
        {
            InitializeComponent();
            _service = service;
            _licService = licService;
            LoadCombosAsync();
            cmbEquipment.SelectedIndexChanged += async (s, e) => await LoadInstalledAsync();
            btnAdd.Click += async (s, e) => await AddInstallationAsync();
            btnRemove.Click += async (s, e) =>
            {
                // Удалить выбранное из ListBox (нужен ID)
                await _service.RemoveInstallationAsync(1); // Пример, используйте SelectedItem
                await LoadInstalledAsync();
            };
        }

        private async Task LoadCombosAsync()
        {
            var equipments = await _service.GetAllAsync();
            cmbEquipment.DataSource = equipments.ToList();
            cmbEquipment.DisplayMember = "Name";
            cmbEquipment.ValueMember = "Id";

            var licenses = await _licService.GetAllAsync();
            cmbLicense.DataSource = licenses.ToList();
            cmbLicense.DisplayMember = "Name";
            cmbLicense.ValueMember = "Id";
        }

        private async Task LoadInstalledAsync()
        {
            if (cmbEquipment.SelectedValue is int eqId)
            {
                var installed = await _service.GetInstalledForEquipmentAsync(eqId);
                listBoxInstalled.DataSource = installed.Select(i => $"{i.License.Name} ({i.InstallDate:dd.MM.yyyy})").ToList();
            }
        }

        private async Task AddInstallationAsync()
        {
            if (cmbEquipment.SelectedValue is int eqId && cmbLicense.SelectedValue is int licId)
            {
                await _service.AddInstallationAsync(eqId, licId, dtpInstall.Value);
                await LoadInstalledAsync();
            }
        }
    }
}