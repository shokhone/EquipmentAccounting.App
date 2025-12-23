using BLL.Services;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsUl
{
    public partial class EquipmentEditForm : Form
    {
        private readonly EquipmentService _service;
        private readonly EquipmentTypeService _typeService;
        private readonly EmployeeService _empService;
        private Equipment? _equipment;
        public EquipmentEditForm(EquipmentService service, EquipmentTypeService typeService, EmployeeService empService, Equipment? equipment = null)
        {
            InitializeComponent();
            _service = service;
            _typeService = typeService;
            _empService = empService;
            _equipment = equipment;
            LoadCombosAsync();
            if (_equipment != null)
            {
                txtInventory.Text = _equipment.InventoryNumber;
                txtName.Text = _equipment.Name;
                txtSerial.Text = _equipment.SerialNumber;
                cmbType.SelectedValue = _equipment.TypeId;
                cmbEmployee.SelectedValue = _equipment.ResponsibleEmployeeId ?? 0;
                dtpDateAdded.Value = _equipment.DateAdded;
                cmbStatus.Text = _equipment.Status;
                Text = "Редактировать оборудование";
            }
            else
            {
                Text = "Добавить оборудование";
                dtpDateAdded.Value = DateTime.Now;
                cmbStatus.Text = "В работе";
            }
            btnSave.Click += async (s, e) => await SaveAsync();
        }

        private async Task LoadCombosAsync()
        {
            var types = await _typeService.GetAllAsync();
            cmbType.DataSource = types.ToList();
            cmbType.DisplayMember = "Name";
            cmbType.ValueMember = "Id";

            var employees = await _empService.GetAllAsync();
            cmbEmployee.DataSource = employees.ToList();
            cmbEmployee.DisplayMember = "FullName";
            cmbEmployee.ValueMember = "Id";
            cmbEmployee.Items.Insert(0, "Без ответственного"); // Index 0 for null

            cmbStatus.Items.AddRange(new string[] { "В работе", "На списании", "В ремонте" });
        }

        private async Task SaveAsync()
        {
            if (string.IsNullOrWhiteSpace(txtInventory.Text) || string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Инвентарный номер и название обязательны!");
                return;
            }

            var eq = _equipment ?? new Equipment();
            eq.InventoryNumber = txtInventory.Text;
            eq.Name = txtName.Text;
            eq.SerialNumber = txtSerial.Text;
            eq.TypeId = (int)cmbType.SelectedValue;
            eq.ResponsibleEmployeeId = cmbEmployee.SelectedIndex == 0 ? null : (int?)cmbEmployee.SelectedValue;
            eq.DateAdded = dtpDateAdded.Value;
            eq.Status = cmbStatus.Text;

            try
            {
                if (_equipment != null)
                    await _service.UpdateAsync(eq);
                else
                    await _service.AddAsync(eq);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Close();
        }
    }
}
