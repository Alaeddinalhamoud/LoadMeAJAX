using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLoadMeAjax.Models;

namespace TestLoadMeAjax.Classes
{
 public interface IEmployee
    {
        IEnumerable<Employee> GetEmployee { get; }
    }
}
