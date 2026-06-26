using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EFCore.Configurations;
using EFCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Contexts
{
    internal class CompanyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source = ISLAM7LMYLAPVM\\ISLAM7LMY; intial Catalog = NXT23.EFMyCompany; Integrated Security = true");
            //optionsBuilder.UseSqlServer("Data Source = ISLAM7LMYLAPVM\\ISLAM7LMY; intial Catalog = NXT23.EFMyCompany; User Id = sa; Password = your_password");
            //optionsBuilder.UseSqlServer("Data Source=ISLAM7LMYLAPVM\\ISLAM7LMY;Initial Catalog=NXT23.EFMyCompany;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
            optionsBuilder.UseSqlServer("Server=ISLAM7LMYLAPVM\\ISLAM7LMY;DataBase=NXT23.EFMyCompany;Trusted_Connection=True;Encrypt=False;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // when inhert from dbcontext contain dbsets as scurity modual has 7 dbsets
            // inhert IdentityDbContext
            //base.OnModelCreating(modelBuilder);

            #region 3. Fluent Api
            #region Ways to access Property
            //modelBuilder.Entity<Employee>()
            //    .Property("Age")
            //    .HasDefaultValue(10);

            //modelBuilder.Entity<Employee>()
            //    .Property(nameof(Employee.Age))
            //    .HasDefaultValue(10);

            //modelBuilder.Entity<Employee>()
            //    .Property(e=>e.Age)
            //    .HasDefaultValue(10);
            #endregion

            #region Shadow property
            //modelBuilder.Entity<Employee>()
            //    .Property<string>("Address")
            //    .HasColumnType("nvarchar(100)");
            #endregion

            #region Mapping to class and don't have it's source code
            //modelBuilder.Entity<Department>()
            //    .ToTable("DepartmentInfo", "dbo")
            //    .HasKey(d => d.DeptId);

            //modelBuilder.Entity<Department>()
            //    .Property(d => d.DeptId)
            //    .UseIdentityColumn(10,10);

            //modelBuilder.Entity<Department>()
            //    .Property(d => d.Name)
            //    .HasColumnName("DepartmentName")
            //    .HasColumnType("varchar")
            //    .HasMaxLength(50)
            //    .IsRequired();

            //modelBuilder.Entity<Department>()
            //    .Property(d => d.CreationDate)
            //    .HasColumnType("Date")
            //    .HasComputedColumnSql("GETDATE()");


            ///efcore 3.1 new feature
            //modelBuilder.Entity<Department>(d => {
            //    d.ToTable("DepartmentInfo", "dbo")
            //        .HasKey(d => d.DeptId);

            //    d.Property(d => d.DeptId)
            //        .UseIdentityColumn(10, 10);

            //    d.Property(d => d.Name)
            //        .HasColumnName("DepartmentName")
            //        .HasColumnType("varchar")
            //        .HasMaxLength(50)
            //        .IsRequired();

            //    d.Property(d => d.CreationDate)
            //        .HasColumnType("Date")
            //        .HasComputedColumnSql("GETDATE()");

            //});
            #endregion
            #endregion

            //modelBuilder.ApplyConfiguration<Department>(new DepartmentConfigurations());
            //modelBuilder.ApplyConfiguration<Employee>(new EmployeeConfigurations());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
