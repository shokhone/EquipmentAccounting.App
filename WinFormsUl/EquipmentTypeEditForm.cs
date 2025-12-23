using BLL.Services;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsUl
{
    public partial class EquipmentTypeEditForm : Form
    {
        private readonly EquipmentTypeService _service;
        private EquipmentType? _type;
        public EquipmentTypeEditForm(EquipmentTypeService service, EquipmentType? type = null)
        {
            InitializeComponent();
            _service = service;
            _type = type;
            if (_type != null)
            {
                txtName.Text = _type.Name;
                Text = "Редактировать тип";
            }
            else
            {
                Text = "Добавить тип";
            }
            btnSave.Click += async (s, e) => await SaveAsync();
        }

        private async Task SaveAsync()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Название обязательно!");
                return;
            }

            var et = _type ?? new EquipmentType();
            et.Name = txtName.Text;

            try
            {
                if (_type != null)
                    await _service.UpdateAsync(et);
                else
                    await _service.AddAsync(et);
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
