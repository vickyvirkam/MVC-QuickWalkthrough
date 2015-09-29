using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.ViewModels
{
    public class CreateEmployeeViewModel:BaseViewModel
    {
        [Required(ErrorMessage = "Username is mandatory")]
        [StringLength(7, ErrorMessage = "Username cannot be more than 7 characters")]
        public string FirstName { set; get; }
        [Required(ErrorMessage = "LastName is mandatory")]
        public string LastName { set; get; }
        public string Salary { set; get; }
    }
}