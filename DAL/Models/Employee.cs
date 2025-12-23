using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(200)]
        public string FullName { get; set; } = string.Empty; // ФИО

        [MaxLength(100)]
        public string Position { get; set; } = string.Empty; // Должность

        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; } = null!;

        // Навигация
        public virtual ICollection<Equipment> ResponsibleEquipments { get; set; } = new List<Equipment>();
        public virtual ICollection<EquipmentHistory> OldAssignments { get; set; } = new List<EquipmentHistory>();
        public virtual ICollection<EquipmentHistory> NewAssignments { get; set; } = new List<EquipmentHistory>();
    }
}