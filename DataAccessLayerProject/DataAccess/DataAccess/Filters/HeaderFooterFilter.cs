using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace DataAccess.Filters
{
    public class HeaderFooterFilter:ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            ViewResult v = filterContext.Result as ViewResult;
            if (v != null)
            {
                BaseViewModel bv = v.Model as BaseViewModel;
                if(bv !=null)
                {
                    bv.UserName = HttpContext.Current.User.Identity.Name;
                bv.FooterData = new FooterViewModel();
                bv.FooterData.CompanyName = "VIKRAM VICKY";
                bv.FooterData.Year = DateTime.Now.ToString();
                }
            
            }

        }
    }
}