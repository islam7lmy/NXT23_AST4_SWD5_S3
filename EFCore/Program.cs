using EFCore.Contexts;
using EFCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region How To Migrate
            //to add db to sql server:

            ///1.Install-Package "Microsoft.EntityFrameworkCore.SqlServer"
            ///2.create Compnydbcontext that inhert DbContext
            ///3.override OnConfiguring and set db conection string
            ///4.add dbset<> for class (Models) that want to be tables
            ///5.install Package Microsoft.EntityFrameworkCore.Tools
            ///6.Add-Migration "InitialCreate"
            ///7.Update-Database
            #endregion

            #region CRUD Operations [create, read, update, delete]
            //unmanaged
            //CompanyDbContext dbContext = new CompanyDbContext();
            //try
            //{
            //    //crud
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    dbContext.Dispose(); //dispose
            //}

            //using (CompanyDbContext db = new CompanyDbContext()) //managed
            //{
            //    //crud
            //}

            using CompanyDbContext db = new CompanyDbContext(); //managed

            Employee E01 = new Employee
            {
                Name = "Ahmed",
                Salary = 1000,
                Age = 30,
            };

            Employee E02 = new Employee
            {
                Name = "Ali",
                Salary = 4000,
                Age = 27,
            };

            //Console.WriteLine(db.Entry(E01).State);
            //Console.WriteLine(db.Entry(E02).State);

            #region Create
            //db.Employees.Add(E01);
            //db.Set<Employee>().Add(E02);
            //db.Add(E01);
            //db.Entry(E01).State = EntityState.Added;

            //db.SaveChanges();

            Console.WriteLine(db.Entry(E01).State);
            db.Employees.Add(E01);
            Console.WriteLine(db.Entry(E01).State);
            db.SaveChanges();
            Console.WriteLine(db.Entry(E01).State);
            #endregion

            #endregion
        }
    }
}
