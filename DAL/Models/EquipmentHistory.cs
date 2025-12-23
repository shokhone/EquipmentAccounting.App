using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class EquipmentHistory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int EquipmentId { get; set; }

        [ForeignKey("EquipmentId")]
        public virtual Equipment Equipment { get; set; } = null!;

        public int? OldEmployeeId { get; set; }  // Изменил название с FromEmployeeId

        [ForeignKey("OldEmployeeId")]
        public virtual Employee? OldEmployee { get; set; }  // Изменил название

        public int? NewEmployeeId { get; set; }  // Изменил название с ToEmployeeId

        [ForeignKey("NewEmployeeId")]
        public virtual Employee? NewEmployee { get; set; }  // Изменил название

        [Required]
        public DateTime MovementDate { get; set; } = DateTime.Now;  // Изменил Date на MovementDate

        [Required, MaxLength(50)]
        public string ActionType { get; set; } = string.Empty;

        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;
    }
}