using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Entities
{
    #region 1. by Convention (Default Bhavior)
    internal class Employee
    {
        public int Id { get; set; } // primary key by convention int [identity(1,1)] not allow null
        public string? Name { get; set; } // nvarchar(max) allow null
        public double Salary { get; set; } // float not allow null
        public int? Age { get; set; } // int allow null
    }
    #endregion
}
