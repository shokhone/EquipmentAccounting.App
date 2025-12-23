// BLL/Services/EquipmentTypeService.cs
using DAL;
using DAL.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class EquipmentTypeService
    {
        private readonly IRepository<EquipmentType> _repository;

        public EquipmentTypeService(EquipmentDbContext context)
        {
            _repository = new GenericRepository<EquipmentType>(context);
        }

        public async Task<IEnumerable<EquipmentType>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<EquipmentType?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddAsync(EquipmentType equipmentType)
        {
            try
            {
                await _repository.AddAsync(equipmentType);
                await _repository.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка добавления типа оборудования: {ex.Message}");
            }
        }

        public async Task UpdateAsync(EquipmentType equipmentType)
        {
            try
            {
                await _repository.UpdateAsync(equipmentType);
                await _repository.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка обновления типа оборудования: {ex.Message}");
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
                throw new Exception($"Ошибка удаления типа оборудования: {ex.Message}");
            }
        }
    }
}