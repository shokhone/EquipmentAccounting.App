// DAL/EquipmentDbContext.cs
using Microsoft.EntityFrameworkCore;
using DAL.Models;

namespace DAL
{
    public class EquipmentDbContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EquipmentType> EquipmentTypes { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<EquipmentHistory> EquipmentHistories { get; set; }
        public DbSet<License> Licenses { get; set; }
        public DbSet<InstalledSoftware> InstalledSoftwares { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = "Server=(localdb)\\mssqllocaldb;Database=EquipmentAccountingApp;Trusted_Connection=true;MultipleActiveResultSets=true;TrustServerCertificate=True";
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // === ОТКЛЮЧЕНИЕ ЦИКЛИЧЕСКИХ КАСКАДОВ ===
            // Глобальное отключение каскадного удаления
            foreach (var relationship in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            // Индекс по InventoryNumber
            modelBuilder.Entity<Equipment>()
                .HasIndex(e => e.InventoryNumber)
                .IsUnique()
                .HasDatabaseName("IX_Equipment_InventoryNumber");

            // === DEPARTMENT - EMPLOYEE ===
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict); // Изменил с Cascade на Restrict

            // === EQUIPMENT - TYPE ===
            modelBuilder.Entity<Equipment>()
                .HasOne(e => e.Type)
                .WithMany(t => t.Equipments)
                .HasForeignKey(e => e.TypeId)
                .OnDelete(DeleteBehavior.Restrict);

            // === EQUIPMENT - EMPLOYEE (Responsible) ===
            modelBuilder.Entity<Equipment>()
                .HasOne(e => e.ResponsibleEmployee)
                .WithMany(emp => emp.ResponsibleEquipments)
                .HasForeignKey(e => e.ResponsibleEmployeeId)
                .OnDelete(DeleteBehavior.SetNull);

            // === EQUIPMENTHISTORY - EQUIPMENT ===
            modelBuilder.Entity<EquipmentHistory>()
                .HasOne(h => h.Equipment)
                .WithMany(e => e.HistoryMovements)
                .HasForeignKey(h => h.EquipmentId)
                .OnDelete(DeleteBehavior.Restrict); // Изменил с Cascade на Restrict

            // === EQUIPMENTHISTORY - EMPLOYEES ===
            // Убрали WithMany() чтобы не создавать циклические ссылки
            modelBuilder.Entity<EquipmentHistory>()
                .HasOne(h => h.OldEmployee)
                .WithMany() // Убрали emp => emp.OldAssignments
                .HasForeignKey(h => h.OldEmployeeId)
                .OnDelete(DeleteBehavior.Restrict); // Изменил с SetNull на Restrict

            modelBuilder.Entity<EquipmentHistory>()
                .HasOne(h => h.NewEmployee)
                .WithMany() // Убрали emp => emp.NewAssignments
                .HasForeignKey(h => h.NewEmployeeId)
                .OnDelete(DeleteBehavior.Restrict); // Изменил с SetNull на Restrict

            // === INSTALLEDSOFTWARE ===
            modelBuilder.Entity<InstalledSoftware>()
                .HasOne(isw => isw.Equipment)
                .WithMany(e => e.InstalledSoftwares)
                .HasForeignKey(isw => isw.EquipmentId)
                .OnDelete(DeleteBehavior.Restrict); // Изменил с Cascade на Restrict

            modelBuilder.Entity<InstalledSoftware>()
                .HasOne(isw => isw.License)
                .WithMany(l => l.Installations)
                .HasForeignKey(isw => isw.LicenseId)
                .OnDelete(DeleteBehavior.Restrict);

            // === ДОПОЛНИТЕЛЬНЫЕ НАСТРОЙКИ ===
            // Для строковых полей с ограничением длины
            modelBuilder.Entity<Employee>()
                .Property(e => e.FullName)
                .HasMaxLength(100);

            modelBuilder.Entity<Equipment>()
                .Property(e => e.InventoryNumber)
                .HasMaxLength(50);

            modelBuilder.Entity<Equipment>()
                .Property(e => e.SerialNumber)
                .HasMaxLength(100);

            modelBuilder.Entity<Equipment>()
                .Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValue("В работе");

            // Seed тестовых данных (5-10 записей)
            SeedData(modelBuilder);
        }

        private static void SeedData(ModelBuilder modelBuilder)
        {
            // Типы оборудования (5 записей)
            modelBuilder.Entity<EquipmentType>().HasData(
                new EquipmentType { Id = 1, Name = "Системный блок" },
                new EquipmentType { Id = 2, Name = "Монитор" },
                new EquipmentType { Id = 3, Name = "Принтер" },
                new EquipmentType { Id = 4, Name = "Ноутбук" },
                new EquipmentType { Id = 5, Name = "Клавиатура" }
            );

            // Подразделения (5 записей)
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "IT-отдел", Manager = "Иванов И.И." },
                new Department { Id = 2, Name = "Бухгалтерия", Manager = "Петрова А.А." },
                new Department { Id = 3, Name = "HR", Manager = "Сидоров В.В." },
                new Department { Id = 4, Name = "Продажи", Manager = "Козлова Е.Е." },
                new Department { Id = 5, Name = "Администрация", Manager = "Генеральный директор" }
            );

        }
    }
}