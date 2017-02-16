using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TestLoadMeAjax.Models;

namespace TestLoadMeAjax.Classes
{
    public class EFDbContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}