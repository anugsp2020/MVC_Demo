using MVC_Basics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Basics.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            ViewBag.Data = "Some data to display";
            return View();
        }

        public ActionResult EmployeeDetails()
        {
            //Employee emp = new Employee();
            //emp.EmpId = 1;
            //emp.EmpName = "John";
            //ViewBag.Data = emp;

            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { EmpId=1,EmpName="John" });
            empList.Add(new Employee() { EmpId = 2, EmpName = "George" });
            ViewBag.Employees = empList;

            return View();
        }

        public ActionResult EmployeeDetailsByModel()
        {
            //Employee emp = new Employee();
            //emp.EmpId = 1;
            //emp.EmpName = "John";
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { EmpId = 1, EmpName = "John" });
            empList.Add(new Employee() { EmpId = 2, EmpName = "George" });
            ViewBag.Employees = empList;
            return View(empList);
        }

        public ActionResult SearchEmployeeBy()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetEmployeeDetailsBy(Employee emp)
        {
            if (ModelState.IsValid)
            {
                List<Employee> empList = new List<Employee>();
                empList.Add(new Employee() { EmpId = 1, EmpName = "John" });
                empList.Add(new Employee() { EmpId = 2, EmpName = "George" });
                var requiredEmployee = empList.Where(x => x.EmpId == emp.EmpId).FirstOrDefault();
                return View(requiredEmployee);
            }
                return View("SearchEmployeeBy", emp);

        }


    }
}