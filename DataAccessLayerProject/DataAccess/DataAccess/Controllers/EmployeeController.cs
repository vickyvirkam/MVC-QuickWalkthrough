using DataAccess.Filters;
using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataAccess.Controllers
{
    public class EmployeeController : Controller
    {
         [AdminFilter]
        [HeaderFooterFilter]
        public ActionResult CreateEmployee()
        {
            CreateEmployeeViewModel cvm = new CreateEmployeeViewModel();
            
            //cvm.UserName = User.Identity.Name;
            cvm.FooterData = new FooterViewModel();
            //cvm.FooterData.CompanyName = "StepByStepSchools";
            //cvm.FooterData.Year = DateTime.Now.Year.ToString();
            return View("CreateEmployee",cvm);
        }
      [HeaderFooterFilter]
        public ActionResult Index()
        {

            EmployeeBusinessLayer ebl = new EmployeeBusinessLayer();
            List<EmployeeViewModel> evlist = new List<EmployeeViewModel>();
            List<Employee> employee = ebl.GetEmployees();
            EmployeeViewModelList elist = new EmployeeViewModelList();
            elist.FooterData = new FooterViewModel();
            foreach (Employee item in employee)
            {
                EmployeeViewModel evm = new EmployeeViewModel();
                evm.EmployeeName = item.EmployeeFirstName + " " + item.EmployeeLastName;
                evm.EmployeeSalary = item.EmployeeSalary.ToString("C");
                if (item.EmployeeSalary > 10000)
                    evm.SalaryColor = "green";
                else
                    evm.SalaryColor = "yellow";
                evlist.Add(evm);
            }
            elist.employees = evlist;
            //elist.UserName = User.Identity.Name;
            //elist.FooterData.CompanyName = "School Students";
            //elist.FooterData.Year = DateTime.Now.Year.ToString();
            return View("Index", elist);
            
        }
        [AdminFilter]
        [HeaderFooterFilter]
        public ActionResult SaveEmployee(CreateEmployeeViewModel cvm)
        {
            Employee emp = new Employee();
            emp.EmployeeFirstName = cvm.FirstName;
            emp.EmployeeLastName = cvm.LastName;
            emp.EmployeeSalary = Convert.ToDouble( cvm.Salary);
            if (ModelState.IsValid)
            {
                EmployeeBusinessLayer ebl = new EmployeeBusinessLayer();
                ebl.AddEmployee(emp);
                return RedirectToAction("Index");
            }
            else
            {
                CreateEmployeeViewModel cvmms = new CreateEmployeeViewModel();
                //cvmms.FooterData = new FooterViewModel();
                //cvmms.FooterData.CompanyName = "Step By Step Schools";
                //cvmms.FooterData.Year = DateTime.Now.Year.ToString(); ;
                cvmms.FirstName = cvm.FirstName;
                cvmms.LastName = cvm.LastName;
                cvmms.Salary = cvm.Salary;
                return View("CreateEmployee",cvm);
            }
           
        }
        [ChildActionOnly]
        [HeaderFooterFilter]
        public ActionResult GetNewLink()
        {
            if (Convert.ToBoolean(Session["Admin"]))
            {
                return View("AddNew");

            }

            else
                return new EmptyResult();

        
        }
	}
}