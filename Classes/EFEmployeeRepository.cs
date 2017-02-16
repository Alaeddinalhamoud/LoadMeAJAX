using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestLoadMeAjax.Models;

namespace TestLoadMeAjax.Classes
{
    public class EFEmployeeRepository : IEmployee
    {
        EFDbContext context = new EFDbContext();
        public IEnumerable<Employee> GetEmployee
        {
            get
            {
                return context.Employees;
            }
        }
    }
}