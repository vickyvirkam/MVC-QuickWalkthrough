using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProject.ViewModels
{
    public class StudentViewModel
    {
        public string StudentName { set; get; }
        public int StudentNo { set; get; }
        public string StudentClg { set; get; }
        public string SalaryOfParent { set; get; }
        public string SalaryColor { set; get; }
    }
}