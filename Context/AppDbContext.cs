using EF02.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Context
{
    internal class AppDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stud_Course>().HasKey(Sc => new { Sc.Stud_Id, Sc.Course_Id });
            modelBuilder.Entity<Course_Inst>().HasKey(Ci => new { Ci.inst_Id, Ci.Course_Id });


            modelBuilder.Entity<Student>()
                        .HasOne(S => S.Department)
                        .WithMany(d => d.Students)
                        .HasForeignKey(s => s.Dep_Id);

            modelBuilder.Entity<Course>()
                        .HasOne(C => C.Topic)
                        .WithMany(t => t.Courses)
                        .HasForeignKey(c => c.Top_Id);

            modelBuilder.Entity<Instructor>()
                        .HasOne(i => i.Department)
                        .WithMany(d => d.Instructors)
                        .HasForeignKey(i => i.Dept_Id)
                        .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Department>()
                        .HasOne(d => d.Manager)
                        .WithOne()
                        .HasForeignKey<Department>(d => d.Ins_Id)
                        .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Stud_Course>()
                        .HasOne(Sc => Sc.Student)
                        .WithMany(s => s.stud_Courses)
                        .HasForeignKey(sc => sc.Stud_Id);

            modelBuilder.Entity<Stud_Course>()
                        .HasOne(Sc => Sc.Course)
                        .WithMany(c => c.stud_Courses)
                        .HasForeignKey(sc => sc.Course_Id);

            modelBuilder.Entity<Course_Inst>()
                        .HasOne(ci => ci.Instructor)
                        .WithMany(i => i.Course_Insts)
                        .HasForeignKey(ci => ci.inst_Id);

            modelBuilder.Entity<Course_Inst>()
                     .HasOne(ci => ci.Course)
                     .WithMany(c => c.Course_Insts)
                     .HasForeignKey(ci => ci.Course_Id);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .;Database = ITI;Trusted_Connection = True;TrustServerCertificate = True");
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

    }
}
