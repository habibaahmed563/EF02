using EF02.Configuration;
using EF02.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Contexts
{
    internal class AppDbContext :DbContext
    {
        public AppDbContext() : base()
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>().HasKey("Id");
            //modelBuilder.Entity<Employee>().HasKey(E => E.Id);
            //modelBuilder.Entity<Employee>().HasKey(nameof(Employee.Id));

            //modelBuilder.Entity<Employee>().HasKey(E => E.Id);
            //modelBuilder.Entity<Employee>().Property(E => E.Id).UseIdentityColumn(10, 10);
            //modelBuilder.Entity<Employee>().Property(E => E.Name)
            //                               .HasColumnName("Employeename")
            //                               .HasColumnType("varchar")
            //                               .HasMaxLength(50)
            //                               .IsRequired();


            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());

            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //modelBuilder.Entity<Employee>().HasOne(E => E.Department)
            //                               .WithOne(D => D.Manager)
            //                               .HasForeignKey<Department>(D => D.EmpId);
            //modelBuilder.Entity<Department>()
            //            .HasOne(D => D.Manager)
            //            .WithOne(E => E.Department)
            //            .HasForeignKey<Department>(D => D.EmpId);



            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Code To Connect To Db 
            optionsBuilder.UseSqlServer("Server = .; Database = AppDBG02 ; Trusted_Connection = True;TrustServerCertificate = True");
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }


    }
}
