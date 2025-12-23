// BLL/Services/LicenseService.cs
using DAL;
using DAL.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class LicenseService
    {
        private readonly IRepository<License> _repository;

        public LicenseService(EquipmentDbContext context)
        {
            _repository = new GenericRepository<License>(context);
        }

        public async Task<IEnumerable<License>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<License?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddAsync(License license)
        {
            try
            {
                await _repository.AddAsync(license);
                await _repository.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка добавления лицензии: {ex.Message}");
            }
        }

        public async Task UpdateAsync(License license)
        {
            try
            {
                await _repository.UpdateAsync(license);
                await _repository.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка обновления лицензии: {ex.Message}");
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                await _repository.DeleteAsync(id);
                await _repository.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка удаления лицензии: {ex.Message}");
            }
        }
    }
}