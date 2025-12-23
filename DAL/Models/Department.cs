using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(100)]
        public string Manager { get; set; } = string.Empty; // Руководитель как строка (ФИО), если не ссылка на Employee

        // Навигация
        public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }

  
}
