// BLL/Services/EmployeeService.cs
using DAL;
using DAL.Models;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class EmployeeService
    {
        private readonly IRepository<Employee> _repository;
        private readonly EquipmentDbContext _context;

        public EmployeeService(EquipmentDbContext context)
        {
            _context = context;
            _repository = new GenericRepository<Employee>(context);
        }

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await _context.Employees
                .Include(e => e.Department)
                .ToListAsync();
        }

        public async Task<Employee?> GetByIdAsync(int id)
        {
            return await _context.Employees
                .Include(e => e.Department)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task AddAsync(Employee employee)
        {
            try
            {
                await _repository.AddAsync(employee);
                await _repository.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка добавления сотрудника: {ex.Message}");
            }
        }

        public async Task UpdateAsync(Employee employee)
        {
            try
            {
                await _repository.UpdateAsync(employee);
                await _repository.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка обновления сотрудника: {ex.Message}");
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                // SetNull для оборудования
                var equipments = await _context.Equipments.Where(e => e.ResponsibleEmployeeId == id).ToListAsync();
                foreach (var eq in equipments)
                {
                    eq.ResponsibleEmployeeId = null;
                }
                await _context.SaveChangesAsync();

                await _repository.DeleteAsync(id);
                await _repository.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка удаления сотрудника: {ex.Message}");
            }
        }

        public async Task<Employee?> FindAsync(Expression<Func<Employee, bool>> predicate)
        {
            return await _repository.FindAsync(predicate);
        }
    }
}