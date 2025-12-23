using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class EquipmentType
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; } = string.Empty; // "Системный блок", "Монитор" и т.д.

        // Навигация
        public virtual ICollection<Equipment> Equipments { get; set; } = new List<Equipment>();
    }
}