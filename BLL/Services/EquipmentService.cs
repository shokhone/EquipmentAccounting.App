// BLL/Services/EquipmentService.cs
using DAL;
using DAL.Models;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class EquipmentService
    {
        private readonly IRepository<Equipment> _repository;
        private readonly IRepository<EquipmentHistory> _historyRepository;
        private readonly EquipmentDbContext _context;

        public EquipmentService(EquipmentDbContext context)
        {
            _context = context;
            _repository = new GenericRepository<Equipment>(context);
            _historyRepository = new GenericRepository<EquipmentHistory>(context);
        }

        public async Task<IEnumerable<Equipment>> GetAllAsync()
        {
            return await _context.Equipments
                .Include(e => e.Type)
                .Include(e => e.ResponsibleEmployee)
                .ThenInclude(emp => emp.Department)
                .ToListAsync();
        }

        public async Task<Equipment?> GetByIdAsync(int id)
        {
            return await _context.Equipments
                .Include(e => e.Type)
                .Include(e => e.ResponsibleEmployee)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task AddAsync(Equipment equipment)
        {
            try
            {
                await _repository.AddAsync(equipment);
                await _repository.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка добавления оборудования: {ex.Message}");
            }
        }

        public async Task UpdateAsync(Equipment equipment)
        {
            try
            {
                await _repository.UpdateAsync(equipment);
                await _repository.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка обновления оборудования: {ex.Message}");
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
                throw new Exception($"Ошибка удаления оборудования: {ex.Message}");
            }
        }

        public async Task<IEnumerable<Equipment>> GetByDepartmentAsync(int deptId)
        {
            return await _context.Equipments
                .Include(e => e.Type)
                .Include(e => e.ResponsibleEmployee)
                .Where(e => e.ResponsibleEmployee != null && e.ResponsibleEmployee.DepartmentId == deptId)
                .ToListAsync();
        }

        public async Task<IEnumerable<EquipmentHistory>> GetHistoryByEquipmentAsync(int eqId)
        {
            return await _context.EquipmentHistories
                .Include(h => h.OldEmployee)
                .Include(h => h.NewEmployee)
                .Where(h => h.EquipmentId == eqId)
                .OrderByDescending(h => h.MovementDate)
                .ToListAsync();
        }

        public async Task<IEnumerable<InstalledSoftware>> GetInstalledForEquipmentAsync(int eqId)
        {
            return await _context.InstalledSoftwares
                .Include(i => i.License)
                .Where(i => i.EquipmentId == eqId)
                .ToListAsync();
        }

        public async Task AddInstallationAsync(int eqId, int licId, DateTime installDate)
        {
            try
            {
                var installation = new InstalledSoftware
                {
                    EquipmentId = eqId,
                    LicenseId = licId,
                    InstallDate = installDate
                };
                _context.InstalledSoftwares.Add(installation);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка установки ПО: {ex.Message}");
            }
        }

        public async Task RemoveInstallationAsync(int id)
        {
            try
            {
                var inst = await _context.InstalledSoftwares.FindAsync(id);
                if (inst != null)
                {
                    _context.InstalledSoftwares.Remove(inst);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка удаления установки ПО: {ex.Message}");
            }
        }

        public async Task AssignToEmployeeAsync(int equipmentId, int? newEmployeeId)
        {
            try
            {
                var equipment = await _context.Equipments
                    .Include(e => e.ResponsibleEmployee)
                    .FirstOrDefaultAsync(e => e.Id == equipmentId);
                if (equipment == null) return;

                var oldEmployeeId = equipment.ResponsibleEmployeeId;
                if (oldEmployeeId == newEmployeeId) return;

                equipment.ResponsibleEmployeeId = newEmployeeId;

                if (oldEmployeeId.HasValue || newEmployeeId.HasValue)
                {
                    var history = new EquipmentHistory
                    {
                        EquipmentId = equipmentId,
                        MovementDate = DateTime.Now,
                        OldEmployeeId = oldEmployeeId,
                        NewEmployeeId = newEmployeeId
                    };
                    await _historyRepository.AddAsync(history);
                    await _historyRepository.SaveChangesAsync();
                }

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка перемещения оборудования: {ex.Message}");
            }
        }

        public async Task<IEnumerable<License>> GetSoftwareForEmployeeAsync(int empId)
        {
            return await _context.Licenses
                .Where(l => _context.InstalledSoftwares
                    .Any(i => i.LicenseId == l.Id && _context.Equipments
                        .Any(eq => eq.Id == i.EquipmentId && eq.ResponsibleEmployeeId == empId)))
                .ToListAsync();
        }
    }
}