using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public DbSet<Employee> Employees { get; set; }
    }
}
