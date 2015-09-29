using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProject.Models
{
    public class Student
    {
        public int StudentNo {set; get;}
        public string StudentFirstName {set; get;}
        public string StudentLastName { set; get; }
        public string StudentClg {set; get;}
        public int ParentSalary { set; get; }
    }
}