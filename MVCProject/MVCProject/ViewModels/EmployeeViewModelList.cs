using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProject.ViewModels
{
    public class EmployeeViewModelList
    {
        public List<EmployeeViewModel> employees { set; get;}
        public string UserName { set; get; }

    }
}