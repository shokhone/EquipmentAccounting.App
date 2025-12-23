using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class InstalledSoftware
    {
        [Key]
        public int Id { get; set; }

        public int EquipmentId { get; set; }

        [ForeignKey("EquipmentId")]
        public virtual Equipment Equipment { get; set; } = null!;

        public int LicenseId { get; set; }

        [ForeignKey("LicenseId")]
        public virtual License License { get; set; } = null!;

        [Required]
        public DateTime InstallDate { get; set; } = DateTime.Now;
    }
}