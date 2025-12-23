
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Equipment
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)] // Индекс по инвентарному номеру
        public string InventoryNumber { get; set; } = string.Empty;

        [Required, MaxLength(200)]
        public string Name { get; set; } = string.Empty;

        public int TypeId { get; set; }

        [ForeignKey("TypeId")]
        public virtual EquipmentType Type { get; set; } = null!;

        [MaxLength(100)]
        public string SerialNumber { get; set; } = string.Empty;

        public int? ResponsibleEmployeeId { get; set; } // Может быть null, если не закреплено

        [ForeignKey("ResponsibleEmployeeId")]
        public virtual Employee? ResponsibleEmployee { get; set; }

        [Required]
        public DateTime DateAdded { get; set; } = DateTime.Now;

        [Required, MaxLength(50)]
        public string Status { get; set; } = "В работе"; // "В работе", "На списании", "В ремонте"

        // Навигация
        public virtual ICollection<EquipmentHistory> HistoryMovements { get; set; } = new List<EquipmentHistory>();
        public virtual ICollection<InstalledSoftware> InstalledSoftwares { get; set; } = new List<InstalledSoftware>();
    }
}