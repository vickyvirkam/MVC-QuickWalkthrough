using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { set; get; }
        [DataAccess.ValidationClasses.FirstNameValidation]
        public string EmployeeFirstName { set; get; }
        [StringLength (5,ErrorMessage="Lastname can't be morethan 5 characters",MinimumLength=3)]
        public string EmployeeLastName { set; get; }
        [RegularExpression (@"[0-9]*\.?[0-9]+",ErrorMessage="salary is numeric")]
        [Range (500,50000)]
        public double EmployeeSalary { set; get; }

    }
}