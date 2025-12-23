using BLL.Interfaces;
using DAL;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IRepository<Department> _repository;

        public DepartmentService(EquipmentDbContext context)
        {
            _repository = new GenericRepository<Department>(context);
        }

        public async Task<IEnumerable<Department>> GetAllAsync() => await _repository.GetAllAsync();

        public async Task<Department?> GetByIdAsync(int id) => await _repository.GetByIdAsync(id);

        public async Task AddAsync(Department department)
        {
            await _repository.AddAsync(department);
            await _repository.SaveChangesAsync();
        }

        public async Task UpdateAsync(Department department)
        {
            await _repository.UpdateAsync(department);
            await _repository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
            await _repository.SaveChangesAsync();
        }
    }
}
