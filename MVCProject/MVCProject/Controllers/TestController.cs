using MVCProject.Models;
using MVCProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Controllers
{
    public class Customer
    {
        #region Member and Methods of Customer Class
        public string customername { set; get; }
        public string address { set; get; }

        public override string ToString()
        {
            return this.customername + "|" + this.address;
        }
        #endregion
    }



    #region TestController
    public class TestController : Controller
    {
        #region Action Methods
        public string GetString()
        {
            return "Hello Brother Wass up??";
        }

        //Action-method
        public Customer Cdetails()
        { 
            Customer Cst = new Customer();
            Cst.customername = "Vinay";
            Cst.address = "Delhi";
            return Cst;
        }
        [NonAction]//Attribute for disabling the Action method..
        public string SimpleMethod()
        {
            return "Vicky";
        }

        public ActionResult GetView()
        {
            return View("welcome");
        }

        public ActionResult GetModel()
        {
            Employee employee = new Employee();
            employee.FirstName = "vicky";
            employee.LastName = "vikram";
            employee.Salary = 20000;
            ViewData["Employee"] = employee;
            return View("Employee");
        
        }

        public ActionResult GetViewBag()
        {
            Student stdnt = new Student();
            stdnt.StudentNo = 1;
            stdnt.StudentFirstName = "siva kumar";
            stdnt.StudentClg = "CBIT";
            ViewBag.student = stdnt;
            return View("Student");
        
        }

        public ActionResult GetStrongView()
        {
            Employee E1 = new Employee();
            E1.Salary = 5000;
            E1.FirstName = "vikas";
            E1.LastName = "pinnuri";
            return View("StrongView", E1);
        
        }

        public ActionResult GetViewModel()
        {
            Employee emp = new Employee();
            emp.FirstName = "Pinnuri";
            emp.LastName = "Vikas";
            emp.Salary = 1000;
            MVCProject.ViewModels.EmployeeViewModel vmemp = new ViewModels.EmployeeViewModel();
            vmemp.EmployeeName = emp.LastName + "" + emp.FirstName;
          
            if (emp.Salary > 10000)
            {
                vmemp.SalaryColor = "yellow";
            }
            else
            {
                vmemp.SalaryColor = "green";
            }

            return View("ViewModel", vmemp);
        }

        public ActionResult StudentInfo()
        {
            Student s = new Student();
            s.StudentFirstName="devendranath";
            s.StudentLastName = "vaggalla";
            s.StudentClg = "NextGen";
            s.ParentSalary = 10000;
            StudentViewModel svm = new StudentViewModel();
            svm.StudentName = s.StudentFirstName + " " + s.StudentLastName;
            svm.StudentClg = s.StudentClg;
            svm.SalaryOfParent = s.ParentSalary.ToString("C");
            if (s.ParentSalary > 5000)
            {
                svm.SalaryColor = "red";
            }
            else
                svm.SalaryColor = "green";
            return View("StudentInfo", svm);
        
        }

        public ActionResult GetEmpList()
        {
            EmployeeViewModelList evml = new EmployeeViewModelList();
            EmployeeBusinessLayer ebl = new EmployeeBusinessLayer();
            List<Employee> employeelist = ebl.GetEmployees();
            List<EmployeeViewModel> empvlist = new List<EmployeeViewModel>();

            foreach (Employee item in employeelist)
            {
                EmployeeViewModel evm = new EmployeeViewModel();
                evm.EmployeeName = item.FirstName + " " + item.LastName;
                evm.EmployeeSalary = item.Salary.ToString("C");
                if (item.Salary > 15000)
                    evm.SalaryColor = "green";
                else
                    evm.SalaryColor = "yellow";
                empvlist.Add(evm);
            }
            evml.employees = empvlist;
            evml.UserName = "Admin";
            return View("GetEmpList", evml);

        
        }

        #endregion


    }
#endregion
   

}