using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccess.ViewModels
{
    //Encapsulated Data for both Header And Footer
    public class BaseViewModel
    {
        public string UserName { set; get; }//Data for Header
        public FooterViewModel FooterData { set; get; }//Data for Footer
    }
}