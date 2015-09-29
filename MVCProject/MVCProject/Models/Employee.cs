using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCProject.Models
{
    /*Employee Model Class*/
    #region Model
    public class Employee
    {
        [Key]
        public int EmployeeId { set; get; }
        [Required (ErrorMessage="FirstName is required;")]
        public string FirstName { set; get; }
        [StringLength (5,ErrorMessage="LastName is requried",MinimumLength=3)]
        public string LastName { set; get; }
        [RegularExpression (@"[0-9]*\.?[0-9]+",ErrorMessage="Salary is numeric")]
        public int Salary { set; get; }

    }
    #endregion
}