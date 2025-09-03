using EF02.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Configuration
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(E => E.Id);
            builder.Property(E => E.Id).UseIdentityColumn(10, 10);
            builder.Property(E => E.Name)
                                           .HasColumnName("Employeename")
                                           .HasColumnType("varchar")
                                           .HasMaxLength(50)
                                           .IsRequired();
            builder.Property(E => E.Salary).HasColumnType("decimal(18,2)").IsRequired(false);
        }
    }
}
