using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class UserDetails
    {
        [Required(ErrorMessage="Username is mandatory")]
        [StringLength(7,ErrorMessage="Username cannot be more than 7 characters")]
        public string Username { set; get; }
        [Required(ErrorMessage = "Password is mandatory")]
        public string Password { set; get; }
    }
}