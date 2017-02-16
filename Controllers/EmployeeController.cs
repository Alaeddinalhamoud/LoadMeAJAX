using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestLoadMeAjax.Classes;

namespace TestLoadMeAjax.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployee _Employee;

        public EmployeeController(IEmployee employee)
        {
            _Employee = employee;
        }
        // GET: Employee
        public ActionResult Index()
        {

            return View();
        }
        [HttpGet]
        public ActionResult GetEmployees()
        {
           return PartialView("_GetEmployees", _Employee.GetEmployee);
        }
    }
}