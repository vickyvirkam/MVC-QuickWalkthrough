using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccess.DataAccessLayer;

namespace DataAccess.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            MyEmpDb serp = new MyEmpDb();
            return serp.employees.ToList();

        }

        public void AddEmployee(Employee e)
        {
            MyEmpDb addemp = new MyEmpDb();
            addemp.employees.Add(e);
            addemp.SaveChanges();
        }

        //public bool IsValidUser(UserDetails ud)
        //{
        //    if (ud.Username == "Admin" && ud.Password == "Admin")
        //    {
        //        return true;
        //    }
        //    else
        //       return false;

        //}

        public UserStatus GetValidUser(UserDetails ud)
        {


            if (ud.Username == "Admin" && ud.Password == "Admin")
            {
                return UserStatus.AuthenticatedAdmin;
            }
            else if (ud.Username == "Vicky" && ud.Password == "Vicky")
            {
                return UserStatus.Authenticateduser;
            }

            else
                return UserStatus.NonAuthenticateduser;

        }

    }
}