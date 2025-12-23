using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class License
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(200)]
        public string Name { get; set; } = string.Empty; // Название ПО

        [MaxLength(100)]
        public string Manufacturer { get; set; } = string.Empty; // Производитель

        [MaxLength(500)]
        public string LicenseKey { get; set; } = string.Empty; // Ключ лицензии

        [Required]
        public DateTime ExpiryDate { get; set; } = DateTime.Now.AddYears(1);

        // Навигация
        public virtual ICollection<InstalledSoftware> Installations { get; set; } = new List<InstalledSoftware>();
    }
}
