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
using System.Xml.Linq;

namespace WinFormsUl
{
    public partial class DepartmentEditForm : Form
    {
        private readonly DepartmentService _service;
        private Department? _department;
        private Department? department;

        public DepartmentEditForm(BLL.Services.DepartmentService service, DAL.Models.Department? dept)
        {
            InitializeComponent();
            _service = service;
            _department = department;
            if (_department != null)
            {
                txtName.Text = _department.Name;
                txtManager.Text = _department.Manager;
                Text = "Редактировать подразделение";
            }
            else
            {
                Text = "Добавить подразделение";
            }
            btnSave.Click += async (s, e) => await SaveAsync();
        }

        private async Task SaveAsync()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Название обязательно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dept = _department ?? new Department();
            dept.Name = txtName.Text;
            dept.Manager = txtManager.Text;

            try
            {
                if (_department != null)
                    await _service.UpdateAsync(dept);
                else
                    await _service.AddAsync(dept);
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