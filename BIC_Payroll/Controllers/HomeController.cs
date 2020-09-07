using BIC_Payroll.Filters;
using DataModel.LoginModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BIC_Payroll.Controllers
{
    [CustomSessionAttribute]
    public class HomeController : Controller
    {
        LoginSessionDetails SessLogObj = new LoginSessionDetails();
     
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}