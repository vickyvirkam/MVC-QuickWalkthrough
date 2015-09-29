using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccess.ViewModels
{
    public class EmployeeViewModelList:BaseViewModel
    {
        public List<EmployeeViewModel> employees { set; get; }
    }
}