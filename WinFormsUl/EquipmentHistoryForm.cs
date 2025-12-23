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
    public partial class EquipmentHistoryForm : Form
    {
        private readonly EquipmentService _service;
        public EquipmentHistoryForm(EquipmentService service)
        {
            InitializeComponent();
            _service = service;
            LoadEquipmentsAsync();
            cmbEquipment.SelectedIndexChanged += async (s, e) => await LoadHistoryAsync();
        }

        private async Task LoadEquipmentsAsync()
        {
            var equipments = await _service.GetAllAsync();
            cmbEquipment.DataSource = equipments.ToList();
            cmbEquipment.DisplayMember = "Name";
            cmbEquipment.ValueMember = "Id";
        }

        private async Task LoadHistoryAsync()
        {
            if (cmbEquipment.SelectedValue is int eqId)
            {
                var history = await _service.GetHistoryByEquipmentAsync(eqId);
                dataGridView1.DataSource = history.ToList();
            }
        }
    }
}