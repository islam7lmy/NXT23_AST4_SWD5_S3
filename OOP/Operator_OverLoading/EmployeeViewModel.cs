using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Operator_OverLoading
{
    ///model => table
    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly BirthDate { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public decimal Detuctions { get { return Salary * .2M; } }

        public EmployeeViewModel ToEmployeeViewModel()
        {
            ///this keyword  => refere to object that calling method
            return new EmployeeViewModel()
            {
                FullName = $"{this.FirstName} {this.LastName}",
                Age = DateTime.Now.Year - this.BirthDate.Year,
                Address = $"{this.Address}, {this.City}, {this.Country}",
                NetSalary = this.Salary - this.Detuctions,
            };
        }
    }

    internal class EmployeeViewModel
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public decimal NetSalary { get; set; }

        public override string ToString()
        {
            return $"Name : {FullName}\nAge : {Age}\nAdress : {Address}\nNetSalary : {NetSalary}";
        }

        public static explicit operator EmployeeViewModel(Employee emp)
        {
            return new EmployeeViewModel()
            {
                FullName = $"{emp.FirstName} {emp.LastName}",
                Age = DateTime.Now.Year - emp.BirthDate.Year,
                Address = $"{emp.Address}, {emp.City}, {emp.Country}",
                NetSalary = emp.Salary - emp.Detuctions,
            };
        }

        /////not recomnded for clean code reasons
        //public static implicit operator EmployeeViewModel(Employee emp)
        //{
        //    return new EmployeeViewModel()
        //    {
        //        FullName = $"{emp.FirstName} {emp.LastName}",
        //        Age = DateTime.Now.Year - emp.BirthDate.Year,
        //        Address = $"{emp.Address}, {emp.City}, {emp.Country}",
        //        NetSalary = emp.Salary - emp.Detuctions,
        //    };
        //}

        //manual mapping
        public static EmployeeViewModel FromEmployee(Employee emp)
        {
            return new EmployeeViewModel()
            {
                FullName = $"{emp.FirstName} {emp.LastName}",
                Age = DateTime.Now.Year - emp.BirthDate.Year,
                Address = $"{emp.Address}, {emp.City}, {emp.Country}",
                NetSalary = emp.Salary - emp.Detuctions,
            };
        }

    }

    static class EmployeeExtenstions
    {
        public static EmployeeViewModel ToEmployeeViewModelExtintion(this Employee emp)
        {
            return new EmployeeViewModel()
            {
                FullName = $"{emp.FirstName} {emp.LastName}",
                Age = DateTime.Now.Year - emp.BirthDate.Year,
                Address = $"{emp.Address}, {emp.City}, {emp.Country}",
                NetSalary = emp.Salary - emp.Detuctions,
            };
        }

    }
}
