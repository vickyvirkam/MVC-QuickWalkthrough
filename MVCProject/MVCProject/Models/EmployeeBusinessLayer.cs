using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCProject.DataAccessLayer;

namespace MVCProject.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {

            SalesERPDAL sdal = new SalesERPDAL();
            return sdal.employees.ToList();


            //List<Employee> emplist = new List<Employee>();
            //Employee emp1 = new Employee();
            //Employee emp2 = new Employee();
            //Employee emp3 = new Employee();
            //emp1.FirstName = "Vikas";
            //emp1.LastName = "Pinnuri";
            //emp1.Salary = 10000;
            //emplist.Add(emp1);

            //emp2.FirstName = "Siva";
            //emp2.LastName = "Chamarthi";
            //emp2.Salary = 20000;
            //emplist.Add(emp2);

            //emp3.FirstName = "Praveen";
            //emp3.LastName = "Rajuri";
            //emp3.Salary = 30000;
            //emplist.Add(emp3);

            //return emplist;
            
        
        
        }
    }
}